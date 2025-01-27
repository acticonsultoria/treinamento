Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Dundas.Charting.WinControl

Public Class clsUsrControleParadaMaquina

#Region "::: FUNCTION / SUB :::"

    'Estrutura
    Private Structure Grafico
        Dim sSerie As String
        Dim sEixoX As String
        Dim dQuantidade As Double
        Dim dValor As Double
    End Structure

    Public Sub GerarGrafico(ByVal oChart As Dundas.Charting.WinControl.Chart, _
                            ByVal sKeyCampoSerie As String, _
                            ByVal sNomeCampoSerie As String, _
                            ByVal sEixoY As String, _
                            ByVal sNomeEixoY As String, _
                            ByVal oGridDados As Janus.Windows.GridEX.GridEX, _
                            ByVal iTipo As Integer, _
                            ByVal sTipo As String)

        Try

            'Variável auxiliar
            Dim oStructGrafico(0) As Grafico
            Dim bFlag As Boolean = True

            'Limpando a ordenação
            oGridDados.RootTable.Groups.Clear()

            'Atribuindo o nome ao gráfico
            oChart.Titles(0).Text = "GRÁFICO DE MONITORAMENTO DE PRODUÇÃO"

            'Limpando as séries
            oChart.Series.Clear()

            'Formatando o eixo X de acordo com o valor escolhido
            oChart.ChartAreas(0).AxisX.Title = "GRÁFICO - " & sNomeEixoY & " / " & sNomeCampoSerie

            oChart.ChartAreas(0).AxisY.Title = sTipo & " - " & sNomeEixoY

            'Percorrendo todas linha da grid
            For Each oRow In oGridDados.GetRows

                'Zerando a variável
                bFlag = False

                If IsDBNull(oRow.Cells.Item(sEixoY).Value) = False And IsDBNull(oRow.Cells.Item(sKeyCampoSerie).Value) = False Then

                    'Verificando se já existe a chava
                    For iCont As Integer = 1 To oStructGrafico.Count - 1

                        'Verificando se já existe a serie com a data
                        If oStructGrafico(iCont).sSerie = oRow.Cells.Item(sKeyCampoSerie).Text Then

                            'Adicionando o valor
                            oStructGrafico(iCont).dQuantidade += 1
                            oStructGrafico(iCont).dValor += oRow.Cells.Item(sEixoY).Value

                            'Saindo do laço
                            bFlag = True
                            Exit For
                        End If
                    Next

                    'Se ele não encontrou a chave, adicioná-la 
                    If bFlag = False Then

                        'Redimensionando o vetor da estrutura
                        ReDim Preserve oStructGrafico(oStructGrafico.Count)

                        'Atribuindo os valores
                        oStructGrafico(oStructGrafico.Count - 1).sSerie = oRow.Cells.Item(sKeyCampoSerie).Text
                        oStructGrafico(oStructGrafico.Count - 1).sEixoX = sNomeCampoSerie
                        oStructGrafico(oStructGrafico.Count - 1).dQuantidade = 1
                        oStructGrafico(oStructGrafico.Count - 1).dValor = oRow.Cells.Item(sEixoY).Value

                    End If

                End If
            Next

            'Depois de montada a estrutura, o gráfico irá ser montado a partir das informações

            'Crinado uma hash table para auxiliar
            Dim oHashSerie As New Hashtable

            'Percorrendo os dados da estrutura
            For iCont As Integer = 1 To oStructGrafico.Count - 1


                With oStructGrafico(iCont)

                    'Se não existir a série selecionada, adicioná-la
                    If Not oHashSerie.ContainsKey(.sSerie) Then

                        'Adicionando no hash
                        oHashSerie.Add(.sSerie, 0)

                        'Adicionando de acordo com o "key" da coluna
                        ChartSerieAdicionar(oChart, .sSerie)

                    End If

                    If iTipo = 1 Then 'Soma
                        'Adicionando os pontos
                        oChart.Series(.sSerie).Points.AddXY( _
                                        .sEixoX, _
                                        CDbl(FormatNumber(.dValor, 2)))
                    Else

                        'Adicionando os pontos
                        oChart.Series(.sSerie).Points.AddXY( _
                                        .sEixoX, _
                                        CDbl(FormatNumber(.dValor / .dQuantidade, 2)))

                    End If
                End With
            Next

            'Recalcular
            oChart.ChartAreas(0).ReCalc()

            'oChart.ResetAutoValues()

        Catch SqlEx As OleDb.OleDbException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

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

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer

        Try

            For i = 0 To UBound(gSelecaoRow)

                'Seta Parametros - Código
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "id_parada_maquina"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.Int
                oSqlParameter(0).Value = gSelecaoRow(i).Cells("id_parada_maquina").Value

                'Executa Query
                ExecuteNonQuery(goDatabaseSCP.sConnectionSCP, CommandType.StoredProcedure, "sp_delete_parada_maquina", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridListagem(ByVal oGrid As Janus.Windows.GridEX.GridEX, _
                                ByVal dDataInicio As Date, _
                                ByVal dDataTermino As Date, _
                                ByVal iOperador As Integer, _
                                ByVal sMotivo As String, _
                                ByVal sMaquinario As String, _
                                ByVal bDesconsiderarAlmoco As Boolean)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(5) As SqlParameter

        Try
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "data_inicio"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Date
            oSqlParameter(0).Value = CDate(Format(dDataInicio, "dd/MM/yyyy") & " 00:00:00")

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_final"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Date
            oSqlParameter(1).Value = CDate(Format(dDataTermino, "dd/MM/yyyy") & " 23:59:59")

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "maquina"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sMaquinario

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "id_operador"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = IIf(iOperador = -1, DBNull.Value, iOperador)

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "motivo"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Value = sMotivo

            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "desconsiderar_almoco"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Bit
            oSqlParameter(5).Value = bDesconsiderarAlmoco

            'Executa Query
            oDataSet = ExecuteDataset(goDatabaseSCP.sConnectionSCP, CommandType.StoredProcedure, "sp_select_parada_maquina_filtros", oSqlParameter)
            With oGrid

                .RootTable.Columns.Item("maquina").DataMember = "maquina"
                .RootTable.Columns.Item("operador").DataMember = "nome_operador"
                .RootTable.Columns.Item("data_inicio").DataMember = "data_inicio_parada"
                .RootTable.Columns.Item("data_termino").DataMember = "data_final_parada"
                .RootTable.Columns.Item("tempo").DataMember = "tempo"
                .RootTable.Columns.Item("motivo").DataMember = "motivo_parada"
                .RootTable.Columns.Item("complemento").DataMember = "complemento"
                .RootTable.Columns.Item("id_parada_maquina").DataMember = "id_parada_maquina"
                .RootTable.Columns.Item("os_setup").DataMember = "os_setup"
                .RootTable.Columns.Item("part_number_setup").DataMember = "part_number_setup"
                .RootTable.Columns.Item("data_inicio_os_setup").DataMember = "data_inicio_os_setup"

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AtualizarLinhaVarios(ByVal oGrid As GridEX, _
                                    ByVal dCarga As Double)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try

            For Each oRow In oGrid.GetRows

                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "id_maquinario"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.Int
                oSqlParameter(0).Value = oRow.Cells.Item("id_maquinario").Value

                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "data"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.Date
                oSqlParameter(1).Value = oRow.Cells.Item("data").Value

                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "carga"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.Float
                oSqlParameter(2).Value = dCarga

                'Executa Query
                ExecuteNonQuery(goDatabaseSCP.sConnectionSCP, CommandType.StoredProcedure, "sp_update_carga_maquina", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AtualizarLinha(ByVal oRow As GridEXRow)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "id_parada_maquina"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = oRow.Cells.Item("id_parada_maquina").Value

            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_inicio_parada"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.DateTime
            oSqlParameter(1).Value = oRow.Cells.Item("data_inicio").Value

            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_final_parada"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.DateTime
            oSqlParameter(2).Value = oRow.Cells.Item("data_termino").Value

            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "motivo_parada"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.VarChar
            oSqlParameter(3).Value = oRow.Cells.Item("motivo").Value

            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "complemento"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Value = oRow.Cells.Item("complemento").Value

            'Executa Query
            ExecuteNonQuery(goDatabaseSCP.sConnectionSCP, CommandType.StoredProcedure, "sp_update_parada_maquina", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub




#End Region

End Class
