Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Dundas.Charting.WinControl

Public Class clsUsrVen000000014

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal lNumeroPedido As Long, _
                        ByVal sDataPrevisaoEntregaInicio As String, _
                        ByVal sDataPrevisaoEntregaTermino As String, _
                        ByVal sCliente As String, _
                        ByVal sProduto As String, _
                        ByVal sDataEntregaInicio As String, _
                        ByVal sDataEntregaTermino As String, _
                        ByVal sStatus As String, _
                        ByVal iEstoque As Integer, _
                        ByVal sDataAceiteInicio As String, _
                        ByVal sDataAceiteTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Número do Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNumeroPedido : i += 1

            'Seta Parametros - Data Previsão Entrega Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_previsao_entrega_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPrevisaoEntregaInicio), sDataPrevisaoEntregaInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Previsão Entrega Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_previsao_entrega_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPrevisaoEntregaTermino), sDataPrevisaoEntregaTermino, DBNull.Value) : i += 1

            'Seta Parametros - Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCliente : i += 1

            'Seta Parametros - Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sProduto : i += 1

            'Seta Parametros - Data Entrega Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrega_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEntregaInicio), sDataEntregaInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Entrega Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrega_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEntregaTermino), sDataEntregaTermino, DBNull.Value) : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sStatus : i += 1

            'Seta Parametros - Data Aceite Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_aceite_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataAceiteInicio), sDataAceiteInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Aceite Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_aceite_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataAceiteTermino), sDataAceiteTermino, DBNull.Value) : i += 1

            'Seta Parametros - Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iEstoque

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_grid_ven000000014", oSqlParameter)

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

    Public Sub LoadGrafico(ByVal oChart As Chart, _
                           ByVal lNumeroPedido As Long, _
                           ByVal sDataPrevisaoEntregaInicio As String, _
                           ByVal sDataPrevisaoEntregaTermino As String, _
                           ByVal sCliente As String, _
                           ByVal sProduto As String, _
                           ByVal sDataEntregaInicio As String, _
                           ByVal sDataEntregaTermino As String, _
                           ByVal sStatus As String, _
                           ByVal iEstoque As Integer, _
                           ByVal sDataAceiteInicio As String, _
                           ByVal sDataAceiteTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(11) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Número do Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNumeroPedido : i += 1

            'Seta Parametros - Data Previsão Entrega Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_previsao_entrega_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPrevisaoEntregaInicio), sDataPrevisaoEntregaInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Previsão Entrega Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_previsao_entrega_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPrevisaoEntregaTermino), sDataPrevisaoEntregaTermino, DBNull.Value) : i += 1

            'Seta Parametros - Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCliente : i += 1

            'Seta Parametros - Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sProduto : i += 1

            'Seta Parametros - Data Entrega Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrega_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEntregaInicio), sDataEntregaInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Entrega Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_entrega_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEntregaTermino), sDataEntregaTermino, DBNull.Value) : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sStatus : i += 1

            'Seta Parametros - Data Aceite Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_aceite_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataAceiteInicio), sDataAceiteInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Aceite Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_aceite_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataAceiteTermino), sDataAceiteTermino, DBNull.Value) : i += 1

            'Seta Parametros - Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iEstoque

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_grafico_ven000000014", oSqlParameter)


            'Carrega Gráfico
            oChart.Series.Clear()
            oChart.Series.Add("PREVISÃO ENTREGA").Type = SeriesChartType.Column
            oChart.Series("PREVISÃO ENTREGA").ValueMembersY = "PREVISÃO ENTREGA"
            oChart.Series("PREVISÃO ENTREGA").ValueMemberX = "Nº PEDIDO"
            oChart.Series("PREVISÃO ENTREGA").ShowLabelAsValue = True
            oChart.Series.Add("DATA ENTREGA").Type = SeriesChartType.Column
            oChart.Series("DATA ENTREGA").ValueMembersY = "DATA ENTREGA"
            oChart.Series("DATA ENTREGA").ValueMemberX = "Nº PEDIDO"
            oChart.Series("DATA ENTREGA").ShowLabelAsValue = True
            oChart.DataSource = oDataSet
            oChart.DataBind()
            'oChart.ResetAutoValues()
            'oChart.ChartAreas(0).AxisY.LabelStyle.Format = "d"
            'oChart.ChartAreas(0).AxisY.IntervalType = DateTimeIntervalType.Days
            oChart.ChartAreas(0).AxisY.Logarithmic = True
            oChart.ChartAreas(0).AxisY.IntervalOffsetType = DateTimeIntervalType.Days

            'oChart.DataBindTable(oDataSet, "Nº PEDIDO")
            'oChart.Series.Add("Previsão Entrega")
            'oChart.Series("Previsão Entrega").Points.DataBind(oSqlDataReader, "Nº PEDIDO", "PREVISÃO ENTREGA", "Tooltip=PREVISÃO ENTREGA")
            ''oChart.Series("Previsão Entrega")("ColumnLabelStyle") = "Outside"
            'oChart.Series.Add("Entrega")
            'oChart.Series("Entrega").Points.DataBind(oSqlDataReader, "Nº PEDIDO", "DATA ENTREGA", "Tooltip=DATA ENTREGA")



            'Seta Formato do Gráfico
            

            'Desabilita 3D
            ' oChart.ChartAreas("Default").Area3DStyle.Enable3D = True

            'Fecha o SqlDataReader
            ' If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
