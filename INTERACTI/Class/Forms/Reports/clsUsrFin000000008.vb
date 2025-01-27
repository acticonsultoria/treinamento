Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsUsrFin000000008

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGridLavalpa(ByVal oGrid As GridEX, _
                        ByVal sTipo As String, _
                        ByVal sDataEmissaoInicio As String, _
                        ByVal sDataEmissaoTermino As String, _
                        ByVal sDataVencimentoInicio As String, _
                        ByVal sDataVencimentoTermino As String, _
                        ByVal sDataPagamentoInicio As String, _
                        ByVal sDataPagamentoTermino As String, _
                        ByVal sCodigoCentroCusto As String, _
                        ByVal bLavalpa As Integer, _
                        ByVal bLeSix As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(10) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Lavalpa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lavalpa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(bLavalpa = 2, DBNull.Value, IIf(bLavalpa = False, 0, 1)) : i += 1

            'Seta Parametros - Le Six
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "le_six"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(bLeSix = 2, DBNull.Value, IIf(bLeSix = False, 0, 1)) : i += 1

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sTipo : i += 1

            'Seta Parametros - Data Emissão Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoInicio), sDataEmissaoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoTermino), sDataEmissaoTermino, DBNull.Value) : i += 1

            'Seta Parametros - Data Vencimento Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataVencimentoInicio), sDataVencimentoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Vencimento Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataVencimentoTermino), sDataVencimentoTermino, DBNull.Value) : i += 1

            'Seta Parametros - Data Pagamento Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPagamentoInicio), sDataPagamentoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Pagamento Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPagamentoTermino), sDataPagamentoTermino, DBNull.Value) : i += 1

            'Seta Parametros - Centro Custo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoCentroCusto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_grid_fin000000008_lavalpa", oSqlParameter)

            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGrid)

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sTipo As String, _
                        ByVal sDataEmissaoInicio As String, _
                        ByVal sDataEmissaoTermino As String, _
                        ByVal sDataVencimentoInicio As String, _
                        ByVal sDataVencimentoTermino As String, _
                        ByVal sDataPagamentoInicio As String, _
                        ByVal sDataPagamentoTermino As String, _
                        ByVal sCodigoCentroCusto As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sTipo : i += 1

            'Seta Parametros - Data Emissão Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoInicio), sDataEmissaoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoTermino), sDataEmissaoTermino, DBNull.Value) : i += 1

            'Seta Parametros - Data Vencimento Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataVencimentoInicio), sDataVencimentoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Vencimento Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataVencimentoTermino), sDataVencimentoTermino, DBNull.Value) : i += 1

            'Seta Parametros - Data Pagamento Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPagamentoInicio), sDataPagamentoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Pagamento Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPagamentoTermino), sDataPagamentoTermino, DBNull.Value) : i += 1

            'Seta Parametros - Centro Custo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_centro_custo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sCodigoCentroCusto : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_grid_fin000000008", oSqlParameter)

            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGrid)

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridSGA(ByVal oGridDimas As GridEX, _
                            ByVal oGridSolutions As GridEX, _
                            ByVal oGridRodrigues As GridEX, _
                            ByVal oGridGroupserv As GridEX, _
                            ByVal oGridTotal As GridEX, _
                            ByVal sTipo As String, _
                            ByVal sDataEmissaoInicio As String, _
                            ByVal sDataEmissaoTermino As String, _
                            ByVal sDataVencimentoInicio As String, _
                            ByVal sDataVencimentoTermino As String, _
                            ByVal sDataPagamentoInicio As String, _
                            ByVal sDataPagamentoTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sTipo : i += 1

            'Seta Parametros - Data Emissão Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoInicio), sDataEmissaoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_emissao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataEmissaoTermino), sDataEmissaoTermino, DBNull.Value) : i += 1

            'Seta Parametros - Data Vencimento Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataVencimentoInicio), sDataVencimentoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Vencimento Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_vencimento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataVencimentoTermino), sDataVencimentoTermino, DBNull.Value) : i += 1

            'Seta Parametros - Data Pagamento Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPagamentoInicio), sDataPagamentoInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Pagamento Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pagamento_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataPagamentoTermino), sDataPagamentoTermino, DBNull.Value) : i += 1

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_sga_grid_fin000000008", oSqlParameter)

            'Configura DataMember Grid
            Call ConfigurarDataMemberGrid(oGridDimas)
            Call ConfigurarDataMemberGrid(oGridSolutions)
            Call ConfigurarDataMemberGrid(oGridRodrigues)
            Call ConfigurarDataMemberGrid(oGridGroupserv)
            Call ConfigurarDataMemberGrid(oGridTotal)


            oGridTotal.DataSource = oDataSet.DefaultViewManager
            oGridTotal.DataMember = oDataSet.Tables(0).TableName

            oGridDimas.DataSource = oDataSet.DefaultViewManager
            oGridDimas.DataMember = oDataSet.Tables(1).TableName

            oGridSolutions.DataSource = oDataSet.DefaultViewManager
            oGridSolutions.DataMember = oDataSet.Tables(2).TableName

            oGridRodrigues.DataSource = oDataSet.DefaultViewManager
            oGridRodrigues.DataMember = oDataSet.Tables(3).TableName

            oGridGroupserv.DataSource = oDataSet.DefaultViewManager
            oGridGroupserv.DataMember = oDataSet.Tables(4).TableName



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub LoadTreeView(ByVal oTreeView As TreeView, _
                            ByVal sDescricao As String, _
                            Optional ByVal iNivel As Integer = 1)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Descricao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 80
            oSqlParameter(i).Value = sDescricao : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nivel"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(sDescricao = "", iNivel, -1) : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_cadastro_basico_centro_custo_treeview", oSqlParameter)

            While oSqlDataReader.Read

                If iNivel = 1 Then

                    Dim oNode As TreeNode
                    oNode = oTreeView.Nodes.Add(oSqlDataReader.Item("codigo_filho"), oSqlDataReader.Item("centro_custo_filho"))
                    oNode.Tag = oSqlDataReader.Item("codigo_filho")
                    iNivel = oSqlDataReader.Item("nivel")
                    oNode.Checked = True

                Else

                    Dim oNodePai As TreeNode
                    Dim oNodeFilho As TreeNode

                    oNodePai = oTreeView.Nodes.Find(oSqlDataReader.Item("codigo_pai"), True)(0)
                    oNodeFilho = oNodePai.Nodes.Add(oSqlDataReader.Item("codigo_filho"), oSqlDataReader.Item("centro_custo_filho"))
                    oNodeFilho.Tag = oSqlDataReader.Item("codigo_filho")
                    oNodeFilho.Checked = True

                End If

            End While

            'Carrega Nível seguinte
            If oSqlDataReader.HasRows Then Call LoadTreeView(oTreeView, "", iNivel + 1)

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridDetalhado(ByVal oGrid As GridEX, _
                                 ByVal iCodigoEmpresa As Integer, _
                                 ByVal sTipo As String, _
                                 ByVal iTipoData As Integer, _
                                 ByVal sDataInicio As String, _
                                 ByVal sDataTermino As String)

        'Variaveis Locais
        Dim oDataSet As New DataSet
        Dim oDataColumn As DataColumn
        Dim oGridExColumnSet As GridEXColumnSet
        Dim oSqlParameter(4) As SqlParameter
        Dim oGridExColumn As GridEXColumn
        Dim i As Integer = 0
        Try



            'Seta Parametros - Tipo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 2
            oSqlParameter(i).Value = sTipo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "tipo_data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iTipoData : i += 1

            'Seta Parametros - Data Emissão Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Emissão Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEmpresa : i += 1

            '
            'Limpando as colunas
            ' oGrid.RootTable.FormatConditions.Clear()
            oGrid.RootTable.ColumnSets.Clear()
            oGrid.RootTable.Columns.Clear()
            oGrid.ScrollBars = Janus.Windows.GridEX.ScrollBars.Both
            oGrid.TotalRow = InheritableBoolean.True
            oGrid.TotalRowFormatStyle.FontBold = TriState.True
            oGrid.TotalRowPosition = TotalRowPosition.BottomFixed
            'Configurando
            oGrid.RootTable.CellLayoutMode = CellLayoutMode.UseColumnSets
            oGrid.RootTable.ColumnSetRowCount = 1
            oGrid.FrozenColumns = 1


            'Configurando as colunas
            oGridExColumn = New GridEXColumn("nivel")
            oGridExColumn.Caption = "Nível"
            oGridExColumn.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            oGridExColumn.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            oGridExColumn.Width = 30
            oGrid.RootTable.Columns.Add(oGridExColumn)


            oGridExColumn = New GridEXColumn("codigo_centro_custo")
            oGridExColumn.Caption = "Código"
            oGridExColumn.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            oGridExColumn.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
            oGridExColumn.Width = 60
            oGrid.RootTable.Columns.Add(oGridExColumn)

            oGridExColumn = New GridEXColumn("descricao")
            oGridExColumn.Caption = "Centro de Custo"
            oGridExColumn.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            oGridExColumn.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near
            oGridExColumn.Width = 300
            oGrid.RootTable.Columns.Add(oGridExColumn)

            'Executa Query e recebendo o dataset
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_sga_grid_fin000000008_mensal", oSqlParameter)


            'Configurando os ColunmsSet
            oGridExColumnSet = oGrid.RootTable.ColumnSets.Add
            oGridExColumnSet.ColumnCount = 3
            oGridExColumnSet.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
            oGridExColumnSet.Caption = "Centro de Custo"
            oGridExColumnSet.Add(oGrid.RootTable.Columns(0), 0, 0)
            oGridExColumnSet.Add(oGrid.RootTable.Columns(1), 0, 1)
            oGridExColumnSet.Add(oGrid.RootTable.Columns(2), 0, 2)



            'oGridExColumnSet.Add(oGrid.RootTable.Columns(3), 0, 2)
            'oGridExColumnSet.Add(oGrid.RootTable.Columns(4), 0, 3)
            'oGridExColumnSet.Add(oGrid.RootTable.Columns(5), 0, 4)
            'oGridExColumnSet.Add(oGrid.RootTable.Columns(6), 0, 5)

            oGrid.RootTable.Columns(0).Width = 30
            oGrid.RootTable.Columns(1).Width = 60
            oGrid.RootTable.Columns(2).Width = 300
            'oGrid.RootTable.Columns(3).Width = 80
            'oGrid.RootTable.Columns(4).Width = 50
            'oGrid.RootTable.Columns(5).Width = 80
            'oGrid.RootTable.Columns(6).Width = 60


            Dim iQtdMeses As Integer = DateDiff(DateInterval.Month, New Date(Year(sDataInicio), Month(sDataInicio), 1), New Date(Year(sDataTermino), Month(sDataTermino), 1))
            'Data atual
            Dim dData As Date = sDataInicio
            Dim iCol As Integer = oGrid.RootTable.Columns.Count - 1

            For iCont As Integer = 0 To iQtdMeses
                ' Inserindo 3 colunas - Necessidade, Stock e Pedido



                'Variável auxiliar
                dData = DateAdd(DateInterval.Month, iCont, CDate(sDataInicio))
                'Adicionando as colunas no dataset
                'oDataColumn = New DataColumn("valor_receita_mes" & CStr(iCont), 0.0.GetType)
                'oDataColumn.DefaultValue = 0.0
                'oDataSet.Tables(0).Columns.Add(oDataColumn)
                'oDataColumn = New DataColumn("valor_despesa_mes" & CStr(iCont), 0.0.GetType)
                'oDataColumn.DefaultValue = 0.0
                'oDataSet.Tables(0).Columns.Add(oDataColumn)
                'oDataColumn = New DataColumn("percentual_receita_mes" & CStr(iCont), 0.0.GetType)
                'oDataColumn.DefaultValue = 0.0
                'oDataSet.Tables(0).Columns.Add(oDataColumn)
                'oDataColumn = New DataColumn("percentual_despesa_mes" & CStr(iCont), 0.0.GetType)
                'oDataColumn.DefaultValue = 0.0
                'oDataSet.Tables(0).Columns.Add(oDataColumn)
                'oDataColumn = New DataColumn("valor_pago_receita_mes" & CStr(iCont), 0.0.GetType)
                'oDataColumn.DefaultValue = 0.0
                'oDataSet.Tables(0).Columns.Add(oDataColumn)
                'oDataColumn = New DataColumn("valor_pago_despesa_mes" & CStr(iCont), 0.0.GetType)
                'oDataColumn.DefaultValue = 0.0
                'oDataSet.Tables(0).Columns.Add(oDataColumn)
                'oDataColumn = New DataColumn("resultado_mes" & CStr(iCont), 0.0.GetType)
                'oDataColumn.DefaultValue = 0.0
                'oDataSet.Tables(0).Columns.Add(oDataColumn)


                ' iCol += 1
                'Adicionando as colunas na grid
                'oGridExColumn = New GridEXColumn("valor_receita_mes" & CStr(iCont))
                'oGridExColumn.Caption = "Receita"
                'oGridExColumn.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
                'oGridExColumn.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                'oGridExColumn.AggregateFunction = AggregateFunction.Sum
                'oGridExColumn.FormatString = "#,#0.00"
                'oGridExColumn.TotalFormatString = "#,#0.00"
                'oGrid.RootTable.Columns.Add(oGridExColumn)

                ' iCol += 1
                'oGridExColumn = New GridEXColumn("valor_despesa_mes" & CStr(iCont))
                'oGridExColumn.Caption = "Despesa"
                'oGridExColumn.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
                'oGridExColumn.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                'oGridExColumn.AggregateFunction = AggregateFunction.Sum
                'oGridExColumn.FormatString = "#,#0.00"
                'oGridExColumn.TotalFormatString = "#,#0.00"
                'oGrid.RootTable.Columns.Add(oGridExColumn)

                iCol += 1
                oGridExColumn = New GridEXColumn("resultado_mes" & CStr(iCont))
                oGridExColumn.Caption = "Resultado"
                oGridExColumn.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oGridExColumn.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
                oGridExColumn.FormatString = "#,#0.00"
                oGridExColumn.AggregateFunction = AggregateFunction.Sum
                oGrid.RootTable.Columns.Add(oGridExColumn)


                oGridExColumnSet = oGrid.RootTable.ColumnSets.Add
                oGridExColumnSet.Key = CStr(Year(dData)) + "_" + Format(Month(dData), "00")
                oGridExColumnSet.ColumnCount = 1

                oGridExColumnSet.Caption = CStr(Month(dData)) + "/" + CStr(Year(dData))
                oGridExColumnSet.HeaderAlignment = Janus.Windows.GridEX.TextAlignment.Center
                oGridExColumnSet.Add(oGrid.RootTable.Columns(iCol), 0, 0)
                'oGridExColumnSet.Add(oGrid.RootTable.Columns(iCol - 2), 0, 1)
                'oGridExColumnSet.Add(oGrid.RootTable.Columns(iCol - 1), 0, 2)
                'oGridExColumnSet.Add(oGrid.RootTable.Columns(iCol - 0), 0, 3)

                'oGridExColumnSet.Add(oGrid.RootTable.Columns(iCol - 2), 0, 0)
                'oGridExColumnSet.Add(oGrid.RootTable.Columns(iCol - 1), 0, 1)
                'oGridExColumnSet.Add(oGrid.RootTable.Columns(iCol - 0), 0, 2)



            Next

            'Configurando os datamembers
            Call ConfigurarDataMemberGrid(oGrid)

            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName

            Dim oFormatCondition As GridEXFormatCondition
            Dim oFormatCellStyleNivel3 As New GridEXFormatStyle
            oFormatCellStyleNivel3.ForeColor = Color.SteelBlue

            Dim oFormatCellStyleNivel2 As New GridEXFormatStyle
            oFormatCellStyleNivel2.ForeColor = Color.Purple

            Dim oFormatCellStyleNivel1 As New GridEXFormatStyle
            oFormatCellStyleNivel1.ForeColor = Color.ForestGreen
            oFormatCellStyleNivel1.FontBold = TriState.True

            Dim oFormatCellStyleNivelSemNivel As New GridEXFormatStyle
            oFormatCellStyleNivelSemNivel.ForeColor = Color.Firebrick
            oFormatCellStyleNivelSemNivel.FontBold = TriState.True

            oFormatCondition = New GridEXFormatCondition(oGrid.RootTable.Columns("nivel"), ConditionOperator.Equal, 3)
            oFormatCondition.FormatStyle = oFormatCellStyleNivel3
            oGrid.RootTable.FormatConditions.Add(oFormatCondition)

            oFormatCondition = New GridEXFormatCondition(oGrid.RootTable.Columns("nivel"), ConditionOperator.Equal, 2)
            oFormatCondition.FormatStyle = oFormatCellStyleNivel2
            oGrid.RootTable.FormatConditions.Add(oFormatCondition)


            oFormatCondition = New GridEXFormatCondition(oGrid.RootTable.Columns("nivel"), ConditionOperator.Equal, 1)
            oFormatCondition.FormatStyle = oFormatCellStyleNivel1
            oGrid.RootTable.FormatConditions.Add(oFormatCondition)

            oFormatCondition = New GridEXFormatCondition(oGrid.RootTable.Columns("nivel"), ConditionOperator.IsNull, "")
            oFormatCondition.FormatStyle = oFormatCellStyleNivelSemNivel
            oGrid.RootTable.FormatConditions.Add(oFormatCondition)


            'Agora inserindo os valores de stock, necessidade e pedido
            'Dim oSqlDataReader As SqlDataReader
            'oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_sga_grid_fin000000008_mensal", oSqlParameter)


            'iQtdMeses = DateDiff(DateInterval.Month, New Date(Year(sDataInicio), Month(sDataInicio), 1), New Date(Year(sDataTermino), Month(sDataTermino), 1))

            'Dim sCodigoCentroCusto As String = ""
            'With oGrid

            '    'Percorrendo os registros
            '    While oSqlDataReader.Read

            '        For iCont As Integer = 0 To iQtdMeses
            '            'Verificando se já está na linha 
            '            If oSqlDataReader.Item("codigo_centro_custo") <> sCodigoCentroCusto Then
            '                'Setando o valor
            '                sCodigoCentroCusto = oSqlDataReader.Item("codigo_centro_custo")
            '                'Encontrando o código sap
            '                .FindAll(.RootTable.Columns("codigo_centro_custo"), ConditionOperator.Equal, sCodigoCentroCusto)
            '            End If

            '            'Setando os valores
            '            .SetValue("valor_receita_mes" & CStr(iCont), oSqlDataReader.Item("valor_receita_mes" & CStr(iCont)))
            '            .SetValue("valor_despesa_mes" & CStr(iCont), oSqlDataReader.Item("valor_despesa_mes" & CStr(iCont)))
            '            .SetValue("percentual_receita_mes" & CStr(iCont), oSqlDataReader.Item("percentual_receita_mes" & CStr(iCont)))
            '            .SetValue("percentual_despesa_mes" & CStr(iCont), oSqlDataReader.Item("percentual_despesa_mes" & CStr(iCont)))
            '            .SetValue("valor_pago_receita_mes" & CStr(iCont), oSqlDataReader.Item("valor_pago_receita_mes" & CStr(iCont)))
            '            .SetValue("valor_pago_despesa_mes" & CStr(iCont), oSqlDataReader.Item("valor_pago_despesa_mes" & CStr(iCont)))
            '            .SetValue("resultado_mes" & CStr(iCont), oSqlDataReader.Item("resultado_mes" & CStr(iCont)))
            '            '.SetValue("stock_" & Replace(oSqlDataReader.Item("data"), "/", "_"), oSqlDataReader.Item("stock"))
            '            '.SetValue("pedido_" & Replace(oSqlDataReader.Item("data"), "/", "_"), oSqlDataReader.Item("placas_pedir"))
            '            'If oSqlDataReader.Item("po") <> "" And Not oGrid.RootTable.ColumnSets.Item(Replace(oSqlDataReader.Item("data"), "/", "_")).Caption.Contains(" - ") Then
            '            '    '.SetValue("po_" & Replace(oSqlDataReader.Item("data"), "/", "_"), oSqlDataReader.Item("po"))
            '            '    oGrid.RootTable.ColumnSets.Item(Replace(oSqlDataReader.Item("data"), "/", "_")).Caption &= " - " & oSqlDataReader.Item("po")
            '            'End If
            '        Next

            '    End While

            'Fechando o recordset
            ' oSqlDataReader.Close()

            '.AutoSizeColumns()
            'oGrid.RootTable.Columns(0).Width = 20
            'Retornando ao valor inicial
            ' .Row = 0
            ' End With



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
