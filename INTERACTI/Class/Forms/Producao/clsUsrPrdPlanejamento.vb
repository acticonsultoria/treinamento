Imports System.Data
Imports System.Data.SqlClient
Imports Janus.Windows.GridEX
Imports INTERACTI.SQLHelper

Public Class clsUsrPrdPlanejamento

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal iCodigoGrupoItem As Integer, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String, _
                        ByVal sProduto As String, _
                        ByVal sMateriaPrima As String, _
                        ByVal lNumeroPedidoVenda As Long, _
                        ByVal sCliente As String, _
                        ByVal bConsiderarPedidoVenda As Boolean, _
                        ByVal bConsiderarEstoque As Boolean, _
                        ByVal bConsiderarEstoqueMinimo As Boolean)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(16) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Grupo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoItem : i += 1

            'Seta Parametros - Data Inicio
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

            'Seta Parametros - Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sProduto : i += 1

            'Seta Parametros - Matéria Prima
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "materia_prima"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sMateriaPrima : i += 1

            'Seta Parametros - Número do Pedido de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNumeroPedidoVenda : i += 1

            'Seta Parametros - Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCliente : i += 1

      

            'Seta Parametros - Considerar Pedido de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "considerar_pedido_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bConsiderarPedidoVenda : i += 1

            'Seta Parametros - Considerar Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "considerar_estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bConsiderarEstoque : i += 1

            'Seta Parametros - Considerar Estoque Mínimo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "considerar_estoque_minimo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bConsiderarEstoqueMinimo : i += 1



            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_producao_planejamento", oSqlParameter)

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

    Public Sub LoadGridBOM(ByVal oGrid As GridEX, _
                        ByVal iCodigoGrupoItem As Integer, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String, _
                        ByVal sProduto As String, _
                        ByVal sMateriaPrima As String, _
                        ByVal lNumeroPedidoVenda As Long, _
                        ByVal sCliente As String, _
                        ByVal bAgruparPedidoVenda As Boolean, _
                        ByVal bConsiderarPedidoVenda As Boolean, _
                        ByVal bConsiderarEstoque As Boolean, _
                        ByVal bConsiderarEstoqueMinimo As Boolean, _
                        ByVal bConsiderarDepositoQualidade As Boolean, _
                        ByVal bConsiderarForecast As Boolean, _
                        ByVal iNumeroMesForecast As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(15) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Grupo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoItem : i += 1

            'Seta Parametros - Data Inicio
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

            'Seta Parametros - Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sProduto : i += 1

            'Seta Parametros - Matéria Prima
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "materia_prima"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sMateriaPrima : i += 1

            'Seta Parametros - Número do Pedido de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNumeroPedidoVenda : i += 1

            'Seta Parametros - Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCliente : i += 1

            'Seta Parametros - Agrupar por Pedido de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agrupar_pedido_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAgruparPedidoVenda : i += 1

            'Seta Parametros - Considerar Pedido de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "considerar_pedido_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bConsiderarPedidoVenda : i += 1

            'Seta Parametros - Considerar Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "considerar_estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bConsiderarEstoque : i += 1

            'Seta Parametros - Considerar Estoque Mínimo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "considerar_estoque_minimo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bConsiderarEstoqueMinimo : i += 1

            'Seta Parametros - Considerar Depósito Qualidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "considerar_deposito_qualidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bConsiderarDepositoQualidade : i += 1

            'Seta Parametros - Considerar Forecast
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "forecast"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bConsiderarForecast : i += 1

            'Seta Parametros - Número Meses Forecast
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_mes_forecast"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroMesForecast : i += 1


            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_producao_planejamento", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("pk"), oDataSet.Tables(1).Columns("pk_pai2"))

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(2).TableName, oDataSet.Tables(1).Columns("pk2"), oDataSet.Tables(2).Columns("pk_pai3"))

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(3).TableName, oDataSet.Tables(2).Columns("pk3"), oDataSet.Tables(3).Columns("pk_pai4"))


            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName
            oGrid.RootTable.ChildTables(0).ChildTables(0).DataMember = oDataSet.Tables(2).TableName
            oGrid.RootTable.ChildTables(0).ChildTables(0).DataMember = oDataSet.Tables(3).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridMolde(ByVal oGrid As GridEX, _
                             ByVal iCodigoGrupoItem As Integer, _
                             ByVal sDataInicio As String, _
                             ByVal sDataTermino As String, _
                             ByVal sProduto As String, _
                             ByVal sMateriaPrima As String, _
                             ByVal lNumeroPedidoVenda As Long, _
                             ByVal sCliente As String, _
                             ByVal bAgruparPedidoVenda As Boolean, _
                             ByVal bConsiderarPedidoVenda As Boolean, _
                             ByVal bConsiderarEstoque As Boolean, _
                             ByVal bConsiderarEstoqueMinimo As Boolean, _
                             ByVal bConsiderarDepositoQualidade As Boolean, _
                             ByVal bConsiderarForecast As Boolean, _
                             ByVal iNumeroMesForecast As Integer, _
                             ByVal iCodigoCor As Integer, _
                             ByVal iCodigoVolume As Integer, _
                             ByVal iCodigoTipoAlca As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(17) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Grupo Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoItem : i += 1

            'Seta Parametros - Data Inicio
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

            'Seta Parametros - Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sProduto : i += 1

            'Seta Parametros - Matéria Prima
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "materia_prima"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sMateriaPrima : i += 1

            'Seta Parametros - Número do Pedido de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNumeroPedidoVenda : i += 1

            'Seta Parametros - Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sCliente : i += 1

            'Seta Parametros - Agrupar por Pedido de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agrupar_pedido_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAgruparPedidoVenda : i += 1

            'Seta Parametros - Considerar Pedido de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "considerar_pedido_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bConsiderarPedidoVenda : i += 1

            'Seta Parametros - Considerar Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "considerar_estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bConsiderarEstoque : i += 1

            'Seta Parametros - Considerar Estoque Mínimo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "considerar_estoque_minimo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bConsiderarEstoqueMinimo : i += 1

            'Seta Parametros - Considerar Depósito Qualidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "considerar_deposito_qualidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bConsiderarDepositoQualidade : i += 1

            'Seta Parametros - Considerar Forecast
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "forecast"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bConsiderarForecast : i += 1

            'Seta Parametros - Número Meses Forecast
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_mes_forecast"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroMesForecast : i += 1

            'Seta Parametros - Código Cor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCor : i += 1

            'Seta Parametros - Código Volume
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_volume"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoVolume : i += 1

            'Seta Parametros - Código Tipo de Alça
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_alca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTipoAlca : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_producao_planejamento_molde", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo"))

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub GerarOrdemProducaoMolde(ByVal lCodigoItem As Long, _
                                       ByVal lCodigoItemPai As Long, _
                                       ByVal iCodigoRoteiroProducao As Integer, _
                                       ByVal iCodigoModeloRoteiroProducao As Integer, _
                                       ByVal iConjunto As Integer, _
                                       ByVal sRevisao As String, _
                                       ByVal iCodigoMolde As Integer, _
                                       ByVal iCodigoMaquina As Integer, _
                                       ByVal dQuantidadePedido As Double, _
                                       ByVal dQuantidadeForecast As Double, _
                                       ByVal dQuantidadeEstoqueMinimo As Double, _
                                       ByVal dQuantidadeEstoque As Double, _
                                       ByVal dQuantidadeProducao As Double, _
                                       ByVal dQuantidadeAmostra As Double, _
                                       ByVal dQuantidadePlanejada As Double, _
                                       ByVal lCodigoPedido As Long, _
                                       ByVal iCodigoPedidoItem As Integer, _
                                       ByVal iCodigoPedidoItemEntrega As Integer, _
                                       ByVal sDataNecessidade As String, _
                                       ByVal iQuantidadeOrdemProducao As Integer, _
                                       ByVal sDataInicio As String, _
                                       ByVal sDataTermino As String, _
                                       Optional ByVal iNumeroMesForecast As Integer = 0)

        'Variaveis Locais
        Dim oSqlParameter(24) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Item Pai
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoItemPai = -1, DBNull.Value, lCodigoItemPai) : i += 1

            'Seta Parametros - Código Roteiro Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_roteiro_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoRoteiroProducao = -1, DBNull.Value, iCodigoRoteiroProducao) : i += 1

            'Seta Parametros - Código Modelo Roteiro Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modelo_roteiro_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoModeloRoteiroProducao = -1, DBNull.Value, iCodigoModeloRoteiroProducao) : i += 1

            'Seta Parametros - Conjunto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conjunto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iConjunto : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5
            oSqlParameter(i).Value = IIf(sRevisao = "", DBNull.Value, sRevisao) : i += 1

            'Seta Parametros - Código Molde
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_molde"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoMolde = -1, DBNull.Value, iCodigoMolde) : i += 1

            'Seta Parametros - Código Máquina
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_maquina"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoMaquina = -1, DBNull.Value, iCodigoMaquina) : i += 1

            'Seta Parametros - Quantidade Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadePedido : i += 1

            'Seta Parametros - Quantidade Forecast
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_forecast"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadeForecast : i += 1

            'Seta Parametros - Estoque Mínimo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "estoque_minimo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadeEstoqueMinimo : i += 1

            'Seta Parametros - Quantidade Estoque
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_estoque"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadeEstoque : i += 1

            'Seta Parametros - Quantidade Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadeProducao : i += 1

            'Seta Parametros - Número Mês Forecast
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_mes_forecast"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroMesForecast : i += 1

            'Seta Parametros - Quantidade Amostra
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_amostra"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadeAmostra : i += 1

            'Seta Parametros - Quantidade Planejada
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_planejada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadePlanejada : i += 1

            'Seta Parametros - Data Necessidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_necessidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataNecessidade), sDataNecessidade, DBNull.Value) : i += 1

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoPedido = -1, DBNull.Value, lCodigoPedido) : i += 1

            'Seta Parametros - Código Pedido Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoPedidoItem = -1, DBNull.Value, iCodigoPedidoItem) : i += 1

            'Seta Parametros - Código Pedido Item Entrega
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoPedidoItemEntrega = -1, DBNull.Value, iCodigoPedidoItemEntrega) : i += 1

            'Seta Parametros - Quantidade - Ordem de Produção
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_ordem_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iQuantidadeOrdemProducao : i += 1

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
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataInicio, DBNull.Value) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_producao_ordem_producao_molde", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub GerarOrdemProducao(ByVal lCodigoItem As Long,
                                  ByVal dQuantidadeProduzir As Double,
                                  ByVal dQuantidadePedido As Double,
                                  ByVal lCodigoPedido As Long,
                                  ByVal iCodigoPedidoItem As Integer,
                                  ByVal iCodigoPedidoItemEntrega As Integer,
                                  ByVal sDataNecessidade As String,
                                  ByVal lCodigoOrdemProducaoPai As Long, _
                                  ByVal lCodigoOrcamento As Long, _
                                  ByVal iCodigoOrcamentoItem As Integer, _
                                  ByVal bAgrupar As Boolean)

        'Variaveis Locais
        Dim oSqlParameter(13) As SqlParameter
        Dim i As Integer = 0

        Try
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "agrupar"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bAgrupar : i += 1


            ''Seta Parametros - Código Item
            'oSqlParameter(i) = New SqlParameter
            'oSqlParameter(i).ParameterName = "codigo_item"
            'oSqlParameter(i).Direction = ParameterDirection.Input
            'oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            'oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Quantidade Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadePedido : i += 1

            'Seta Parametros - Quantidade Produzir
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_produzir"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidadeProduzir : i += 1

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoPedido = -1, DBNull.Value, lCodigoPedido) : i += 1

            'Seta Parametros - Código Pedido Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoPedidoItem = -1, DBNull.Value, iCodigoPedidoItem) : i += 1

            'Seta Parametros - Código Pedido Item Entrega
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoPedidoItemEntrega = -1, DBNull.Value, iCodigoPedidoItemEntrega) : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_orcamento_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoOrcamentoItem = -1, DBNull.Value, iCodigoOrcamentoItem) : i += 1


            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_orcamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoOrcamento = -1, DBNull.Value, lCodigoOrcamento) : i += 1

            'Seta Parametros - Data Necessidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_necessidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataNecessidade : i += 1

            'Seta Parametros - Código Ordem Produção Original
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ordem_producao_pai"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoOrdemProducaoPai = -1, DBNull.Value, lCodigoOrdemProducaoPai) : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Codigo Ordem Producao
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ordem_producao"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_producao_ordem_producao", oSqlParameter)

            Dim lCodigoOrdemProducao As Long = oSqlParameter(i).Value

            If bAgrupar = True Then Exit Sub

            'Verifica se existem "filhos" para essa ordem de produção
            i = 0
            Dim oSqlParameter_Children(3) As SqlParameter
            Dim oSqlDataReader As SqlDataReader


            'Seta Parametros - Código Orcamento
            oSqlParameter_Children(i) = New SqlParameter
            oSqlParameter_Children(i).ParameterName = "codigo_orcamento"
            oSqlParameter_Children(i).Direction = ParameterDirection.Input
            oSqlParameter_Children(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter_Children(i).Value = lCodigoOrcamento : i += 1

            'Seta Parametros - Código orçamento item
            oSqlParameter_Children(i) = New SqlParameter
            oSqlParameter_Children(i).ParameterName = "codigo_orcamento_item"
            oSqlParameter_Children(i).Direction = ParameterDirection.Input
            oSqlParameter_Children(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter_Children(i).Value = iCodigoOrcamentoItem : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter_Children(i) = New SqlParameter
            oSqlParameter_Children(i).ParameterName = "codigo_empresa"
            oSqlParameter_Children(i).Direction = ParameterDirection.Input
            oSqlParameter_Children(i).SqlDbType = SqlDbType.Int
            oSqlParameter_Children(i).Value = goUsuario.iEmpresa : i += 1

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_producao_ordem_producao_children", oSqlParameter_Children)

            'Percorre todos os itens para ir gerando as OP´s
            While oSqlDataReader.Read

                If lCodigoOrdemProducao = 1735 Then

                    lCodigoOrdemProducao = 1735
                End If

                'Gera os filhos 
                GerarOrdemProducao(-1,
                                                       oSqlDataReader.Item("quantidade") * dQuantidadeProduzir,
                                                       oSqlDataReader.Item("quantidade"),
                                                       lCodigoPedido,
                                                       iCodigoPedidoItem,
                                                       iCodigoPedidoItemEntrega,
                                                       sDataNecessidade,
                                                       lCodigoOrdemProducao, _
                                                       oSqlDataReader.Item("codigo_orcamento"), _
                                                       oSqlDataReader.Item("codigo_orcamento_item"), _
                                                       bAgrupar)

            End While

            'Fecha o dataset 
            oSqlDataReader.Close()
        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub ValidaForecast(ByVal lCodigoItem As Long, _
                              ByVal iCodigoMolde As Integer, _
                              ByVal iConjunto As Integer, _
                              ByVal dQuantidade As Double, _
                              ByVal iNumeroMes As Integer, _
                              ByRef sMensagem As String)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Molde
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_molde"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoMolde : i += 1

            'Seta Parametros - Conjunto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "conjunto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iConjunto : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Nº Mes
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_mes"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroMes : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Mensagem
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "mensagem"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_producao_forecast", oSqlParameter)

            sMensagem = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaOrdemProducao(ByVal lCodigoItem As Long) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            ValidaOrdemProducao = False

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_producao_planejamento_ordem_producao", oSqlParameter), String)

            'Seta Retorno da Função
            ValidaOrdemProducao = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
