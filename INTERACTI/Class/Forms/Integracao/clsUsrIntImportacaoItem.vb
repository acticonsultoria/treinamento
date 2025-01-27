Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports System.IO
Imports System.Drawing.Imaging


Public Class clsUsrIntImportacaoItem

#Region "::: VÁRIAVEIS :::"

    'Estrutura de Itens
    Public Structure Importacao
        Dim sCampo As String
        Dim iColuna As Integer
        Dim sValorDefault As String
        Dim bSelecionado As Boolean
    End Structure

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGridConfiguracao(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oDataSet As DataSet

        Try

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_integracao_importacao_item")
            
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

    Public Sub UpdateConfiguracao(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim oRow() As GridEXRow = oGrid.GetDataRows
        Dim i As Integer

        Try

            For i = 0 To UBound(oRow)

                'Seta Parametros - Importa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "importa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.Bit
                oSqlParameter(0).Value = oRow(i).Cells("x").Value

                'Seta Parametros - Coluna
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "coluna"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.VarChar
                oSqlParameter(1).Size = 2
                oSqlParameter(1).Value = oRow(i).Cells("coluna").Value

                'Seta Parametros - Valor Default
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "valor_default"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.NVarChar
                oSqlParameter(2).Size = 500
                oSqlParameter(2).Value = oRow(i).Cells("valor_default").Value

                'Seta Parametros - Codigo
                oSqlParameter(3) = New SqlParameter
                oSqlParameter(3).ParameterName = "codigo"
                oSqlParameter(3).Direction = ParameterDirection.Input
                oSqlParameter(3).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(3).Value = oRow(i).Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_integracao_importacao_item", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal sArquivo As String, _
                        ByVal sPlanilha As String, _
                        ByVal oGrid As GridEX, _
                        ByVal oImportacao As Importacao, _
                        ByVal oLayout As Hashtable)

        Try

            'Variaveis Locais
            Dim sQuery As String
            Dim oSqlDataReader As SqlDataReader
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCCodigoTipoItem As New DataColumn("codigo_tipo_item")
            Dim oDCCodigoGrupoItem As New DataColumn("codigo_grupo_item")
            Dim oDCCodigoItem As New DataColumn("codigo_item")
            Dim oDCCodigoBarras As New DataColumn("codigo_barras")
            Dim oDCAtivo As New DataColumn("ativo")
            Dim oDCDescricao As New DataColumn("descricao")
            Dim oDCDescricao2 As New DataColumn("descricao2")
            Dim oDCCodigoNCM As New DataColumn("codigo_ncm")
            Dim oDCPesoLiquido As New DataColumn("peso_liquido")
            Dim oDCCodigoOrigemItem As New DataColumn("codigo_origem_item")
            Dim oDCObservacao As New DataColumn("observacao")
            Dim oDCFoto As New DataColumn("foto")
            Dim oDCCodigoUnidadeMedidaVenda As New DataColumn("codigo_unidade_medida_venda")
            Dim oDCFatorConversaoUnidadeMedidaVenda As New DataColumn("fator_conversao_unidade_medida_venda")
            Dim oDCKit As New DataColumn("kit")
            Dim oDCCodigoFormaVendaItem As New DataColumn("codigo_forma_venda_item")
            Dim oDCPrecoVenda As New DataColumn("preco_venda")
            Dim oDCMargemLucro As New DataColumn("margem_lucro")
            Dim oDCCodigoUnidadeMedidaCompra As New DataColumn("codigo_unidade_medida_compra")
            Dim oDCFatorConversaoUnidadeMedidaCompra As New DataColumn("fator_conversao_unidade_medida_compra")
            Dim oDCLeadTime As New DataColumn("lead_time")
            Dim oDCCodigoUnidadeMedidaEstoque As New DataColumn("codigo_unidade_medida_estoque")
            Dim oDCCodigoDeposito As New DataColumn("codigo_deposito")
            Dim oDCEstoqueMinimo As New DataColumn("estoque_minimo")
            Dim oDCEstoqueMaximo As New DataColumn("estoque_maximo")
            Dim oDCControlaLote As New DataColumn("controla_lote")
            Dim oDCPercentualDesvalorizacao As New DataColumn("percentual_desvalorizacao")
            Dim oDCFrequenciaDesvalorizacaoDia As New DataColumn("frequencia_desvalorizacao_dia")
            Dim oDCItemEstoque As New DataColumn("item_estoque")
            Dim oDCItemCompra As New DataColumn("item_compra")
            Dim oDCItemVenda As New DataColumn("item_venda")
            Dim oDCItemAtivoFixo As New DataColumn("item_ativo_fixo")
            Dim oDCTipoItem As New DataColumn("tipo_item")
            Dim oDCGrupoItem As New DataColumn("grupo_item")
            Dim oDCNCM As New DataColumn("ncm")
            Dim oDCOrigemItem As New DataColumn("origem_item")
            Dim oDCUnidadeMedidaVenda As New DataColumn("unidade_medida_venda")
            Dim oDCFormaVendaItem As New DataColumn("forma_venda_item")
            Dim oDCUnidadeMedidaCompra As New DataColumn("unidade_medida_compra")
            Dim oDCUnidadeMedidaEstoque As New DataColumn("unidade_medida_estoque")
            Dim oDCDeposito As New DataColumn("deposito")

            'Limpa Grid
            oGrid.DataSource = Nothing

            'Seleciona Dados da Planilha Excel
            sQuery = "SELECT * FROM OPENROWSET('Microsoft.Jet.OLEDB.4.0', 'Excel 8.0;Database=" & sArquivo & ";HDR=YES', 'SELECT * FROM [" & sPlanilha & "$]')"
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.Text, sQuery)


            oDCAtivo.DataType = False.GetType
            oDCKit.DataType = False.GetType
            oDCItemEstoque.DataType = False.GetType
            oDCItemCompra.DataType = False.GetType
            oDCItemVenda.DataType = False.GetType
            oDCItemAtivoFixo.DataType = False.GetType
            oDCControlaLote.DataType = False.GetType

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCCodigoTipoItem)
                oDataTable.Columns.Add(oDCCodigoGrupoItem)
                oDataTable.Columns.Add(oDCCodigoItem)
                oDataTable.Columns.Add(oDCCodigoBarras)
                oDataTable.Columns.Add(oDCAtivo)
                oDataTable.Columns.Add(oDCDescricao)
                oDataTable.Columns.Add(oDCDescricao2)
                oDataTable.Columns.Add(oDCCodigoNCM)
                oDataTable.Columns.Add(oDCPesoLiquido)
                oDataTable.Columns.Add(oDCCodigoOrigemItem)
                oDataTable.Columns.Add(oDCObservacao)
                oDataTable.Columns.Add(oDCFoto)
                oDataTable.Columns.Add(oDCCodigoUnidadeMedidaVenda)
                oDataTable.Columns.Add(oDCFatorConversaoUnidadeMedidaVenda)
                oDataTable.Columns.Add(oDCKit)
                oDataTable.Columns.Add(oDCCodigoFormaVendaItem)
                oDataTable.Columns.Add(oDCPrecoVenda)
                oDataTable.Columns.Add(oDCMargemLucro)
                oDataTable.Columns.Add(oDCCodigoUnidadeMedidaCompra)
                oDataTable.Columns.Add(oDCFatorConversaoUnidadeMedidaCompra)
                oDataTable.Columns.Add(oDCLeadTime)
                oDataTable.Columns.Add(oDCCodigoUnidadeMedidaEstoque)
                oDataTable.Columns.Add(oDCCodigoDeposito)
                oDataTable.Columns.Add(oDCEstoqueMinimo)
                oDataTable.Columns.Add(oDCEstoqueMaximo)
                oDataTable.Columns.Add(oDCControlaLote)
                oDataTable.Columns.Add(oDCPercentualDesvalorizacao)
                oDataTable.Columns.Add(oDCFrequenciaDesvalorizacaoDia)
                oDataTable.Columns.Add(oDCItemEstoque)
                oDataTable.Columns.Add(oDCItemCompra)
                oDataTable.Columns.Add(oDCItemVenda)
                oDataTable.Columns.Add(oDCItemAtivoFixo)
                oDataTable.Columns.Add(oDCTipoItem)
                oDataTable.Columns.Add(oDCGrupoItem)
                oDataTable.Columns.Add(oDCNCM)
                oDataTable.Columns.Add(oDCOrigemItem)
                oDataTable.Columns.Add(oDCUnidadeMedidaVenda)
                oDataTable.Columns.Add(oDCFormaVendaItem)
                oDataTable.Columns.Add(oDCUnidadeMedidaCompra)
                oDataTable.Columns.Add(oDCUnidadeMedidaEstoque)
                oDataTable.Columns.Add(oDCDeposito)
            End If

            While oSqlDataReader.Read

                'Checa se o Código do Item é Nulo
                oImportacao = oLayout("codigo_item")
                If IsDBNull(oSqlDataReader.Item(oImportacao.iColuna - 1)) = False Then

                    'Adiciona Linhas ao DataTable
                    oDataRow = oDataTable.NewRow

                    'Código Tipo de Item
                    oImportacao = oLayout("codigo_tipo_item")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("tipo_item") = LoadCodigo("sp_select_static_descricao_tipo_item " & oImportacao.sValorDefault)
                            oDataRow("codigo_tipo_item") = LoadCodigo("sp_select_static_codigo_tipo_item " & oImportacao.sValorDefault)
                        Else
                            oDataRow("tipo_item") = LoadCodigo("sp_select_static_descricao_tipo_item " & oSqlDataReader.Item(oImportacao.iColuna - 1))
                            oDataRow("codigo_tipo_item") = LoadCodigo("sp_select_static_codigo_tipo_item " & oSqlDataReader.Item(oImportacao.iColuna - 1))
                        End If
                    Else
                        oDataRow("tipo_item") = DBNull.Value
                        oDataRow("codigo_tipo_item") = DBNull.Value
                    End If

                    'Código Grupo de Item
                    oImportacao = oLayout("grupo_item")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("codigo_grupo_item") = LoadCodigo("sp_select_cadastro_basico_codigo_grupo_item '" & oImportacao.sValorDefault & "', " & goUsuario.iEmpresa)
                            oDataRow("grupo_item") = oImportacao.sValorDefault
                        Else
                            oDataRow("codigo_grupo_item") = LoadCodigo("sp_select_cadastro_basico_codigo_grupo_item '" & oSqlDataReader.Item(oImportacao.iColuna - 1) & "', " & goUsuario.iEmpresa)
                            oDataRow("grupo_item") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                        End If
                    Else
                        oDataRow("grupo_item") = DBNull.Value
                        oDataRow("codigo_grupo_item") = DBNull.Value
                    End If

                    'Código Item
                    oImportacao = oLayout("codigo_item")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("codigo_item") = oImportacao.sValorDefault
                        Else
                            oDataRow("codigo_item") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                        End If
                    Else
                        oDataRow("codigo_item") = DBNull.Value
                    End If

                    'Código Item
                    oImportacao = oLayout("codigo_barras")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("codigo_barras") = oImportacao.sValorDefault
                        Else
                            oDataRow("codigo_barras") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                        End If
                    Else
                        oDataRow("codigo_barras") = DBNull.Value
                    End If

                    'Ativo
                    oImportacao = oLayout("ativo")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("ativo") = CBool(oImportacao.sValorDefault)
                        Else
                            oDataRow("ativo") = CBool(oSqlDataReader.Item(oImportacao.iColuna - 1))
                        End If
                    Else
                        oDataRow("ativo") = True
                    End If

                    'Descrição
                    oImportacao = oLayout("descricao")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("descricao") = oImportacao.sValorDefault
                        Else
                            oDataRow("descricao") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                        End If
                    Else
                        oDataRow("descricao") = DBNull.Value
                    End If

                    'Descrição 2
                    oImportacao = oLayout("descricao2")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("descricao2") = oImportacao.sValorDefault
                        Else
                            oDataRow("descricao2") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                        End If
                    Else
                        oDataRow("descricao2") = DBNull.Value
                    End If

                    'Código NCM
                    oImportacao = oLayout("ncm")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("ncm") = oImportacao.sValorDefault
                            oDataRow("codigo_ncm") = LoadCodigo("sp_select_cadastro_basico_codigo_ncm '" & oImportacao.sValorDefault & "', " & goUsuario.iEmpresa)
                        Else
                            oDataRow("ncm") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                            oDataRow("codigo_ncm") = LoadCodigo("sp_select_cadastro_basico_codigo_ncm '" & oSqlDataReader.Item(oImportacao.iColuna - 1) & "', " & goUsuario.iEmpresa)
                        End If
                    Else
                        oDataRow("codigo_ncm") = DBNull.Value
                        oDataRow("ncm") = DBNull.Value
                    End If

                    'Peso Líquido
                    oImportacao = oLayout("peso_liquido")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("peso_liquido") = oImportacao.sValorDefault
                        Else
                            oDataRow("peso_liquido") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                        End If
                    Else
                        oDataRow("peso_liquido") = DBNull.Value
                    End If

                    'Código Origem do Item
                    oImportacao = oLayout("codigo_origem_item")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("codigo_origem_item") = oImportacao.sValorDefault
                            oDataRow("origem_item") = LoadCodigo("sp_select_static_codigo_origem_item " & oImportacao.sValorDefault)
                        Else
                            oDataRow("codigo_origem_item") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                            oDataRow("origem_item") = LoadCodigo("sp_select_static_codigo_origem_item " & oSqlDataReader.Item(oImportacao.iColuna - 1))
                        End If
                    Else
                        oDataRow("codigo_origem_item") = DBNull.Value
                        oDataRow("origem_item") = DBNull.Value
                    End If

                    'Observação
                    oImportacao = oLayout("observacao")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("observacao") = oImportacao.sValorDefault
                        Else
                            oDataRow("observacao") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                        End If
                    Else
                        oDataRow("observacao") = DBNull.Value
                    End If

                    'Foto
                    oImportacao = oLayout("foto")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("foto") = oImportacao.sValorDefault
                        Else
                            oDataRow("foto") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                        End If
                    Else
                        oDataRow("foto") = DBNull.Value
                    End If

                    'Unidade de Medida de Venda
                    oImportacao = oLayout("unidade_medida_venda")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("codigo_unidade_medida_venda") = LoadCodigo("sp_select_cadastro_basico_codigo_unidade_medida '" & oImportacao.sValorDefault & "', " & goUsuario.iEmpresa)
                            oDataRow("unidade_medida_venda") = oImportacao.sValorDefault
                        Else
                            oDataRow("codigo_unidade_medida_venda") = LoadCodigo("sp_select_cadastro_basico_codigo_unidade_medida '" & oSqlDataReader.Item(oImportacao.iColuna - 1) & "', " & goUsuario.iEmpresa)
                            oDataRow("unidade_medida_venda") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                        End If
                    Else
                        oDataRow("codigo_unidade_medida_venda") = DBNull.Value
                        oDataRow("unidade_medida_venda") = DBNull.Value
                    End If

                    'Fator de Conversão de Unidade de Medida Venda
                    oImportacao = oLayout("fator_conversao_unidade_medida_venda")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("fator_conversao_unidade_medida_venda") = oImportacao.sValorDefault
                        Else
                            oDataRow("fator_conversao_unidade_medida_venda") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                        End If
                    Else
                        oDataRow("fator_conversao_unidade_medida_venda") = DBNull.Value
                    End If

                    'Kit
                    oImportacao = oLayout("kit")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("kit") = CBool(oImportacao.sValorDefault)
                        Else
                            oDataRow("kit") = CBool(oSqlDataReader.Item(oImportacao.iColuna - 1))
                        End If
                    Else
                        oDataRow("kit") = False
                    End If

                    'Código Forma de Venda Venda
                    oImportacao = oLayout("codigo_forma_venda_item")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("codigo_forma_venda_item") = LoadCodigo("sp_select_static_codigo_forma_venda_item " & oImportacao.sValorDefault)
                            oDataRow("forma_venda_item") = LoadCodigo("sp_select_static_descricao_forma_venda_item " & oImportacao.sValorDefault)
                        Else
                            oDataRow("forma_venda_item") = LoadCodigo("sp_select_static_descricao_forma_venda_item " & oSqlDataReader.Item(oImportacao.iColuna - 1))
                            oDataRow("codigo_forma_venda_item") = LoadCodigo("sp_select_static_codigo_forma_venda_item " & oSqlDataReader.Item(oImportacao.iColuna - 1))
                        End If
                    Else
                        oDataRow("codigo_forma_venda_item") = DBNull.Value
                        oDataRow("forma_venda_item") = DBNull.Value
                    End If

                    'Preço de Venda
                    oImportacao = oLayout("preco_venda")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("preco_venda") = oImportacao.sValorDefault
                        Else
                            oDataRow("preco_venda") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                        End If
                    Else
                        oDataRow("preco_venda") = DBNull.Value
                    End If

                    'Margem de Lucro
                    oImportacao = oLayout("margem_lucro")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("margem_lucro") = oImportacao.sValorDefault
                        Else
                            oDataRow("margem_lucro") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                        End If
                    Else
                        oDataRow("margem_lucro") = DBNull.Value
                    End If

                    'Unidade de Medida de Compra
                    oImportacao = oLayout("unidade_medida_compra")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("codigo_unidade_medida_compra") = LoadCodigo("sp_select_cadastro_basico_codigo_unidade_medida '" & oImportacao.sValorDefault & "', " & goUsuario.iEmpresa)
                            oDataRow("unidade_medida_compra") = oImportacao.sValorDefault
                        Else
                            oDataRow("unidade_medida_compra") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                            oDataRow("codigo_unidade_medida_compra") = LoadCodigo("sp_select_cadastro_basico_codigo_unidade_medida '" & oSqlDataReader.Item(oImportacao.iColuna - 1) & "', " & goUsuario.iEmpresa)
                        End If
                    Else
                        oDataRow("unidade_medida_compra") = DBNull.Value
                        oDataRow("codigo_unidade_medida_compra") = DBNull.Value
                    End If

                    'Fator de Conversão de Unidade de Medida Compra
                    oImportacao = oLayout("fator_conversao_unidade_medida_compra")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("fator_conversao_unidade_medida_compra") = oImportacao.sValorDefault
                        Else
                            oDataRow("fator_conversao_unidade_medida_compra") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                        End If
                    Else
                        oDataRow("fator_conversao_unidade_medida_compra") = DBNull.Value
                    End If

                    'Lead Time
                    oImportacao = oLayout("lead_time")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("lead_time") = oImportacao.sValorDefault
                        Else
                            oDataRow("lead_time") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                        End If
                    Else
                        oDataRow("lead_time") = DBNull.Value
                    End If

                    'Unidade de Medida de Estoque
                    oImportacao = oLayout("unidade_medida_estoque")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("codigo_unidade_medida_estoque") = LoadCodigo("sp_select_cadastro_basico_codigo_unidade_medida '" & oImportacao.sValorDefault & "', " & goUsuario.iEmpresa)
                            oDataRow("unidade_medida_estoque") = oImportacao.sValorDefault
                        Else
                            oDataRow("unidade_medida_estoque") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                            oDataRow("codigo_unidade_medida_estoque") = LoadCodigo("sp_select_cadastro_basico_codigo_unidade_medida '" & oSqlDataReader.Item(oImportacao.iColuna - 1) & "', " & goUsuario.iEmpresa)
                        End If
                    Else
                        oDataRow("codigo_unidade_medida_estoque") = DBNull.Value
                    End If

                    'Depósito
                    oImportacao = oLayout("deposito")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("codigo_deposito") = LoadCodigo("sp_select_cadastro_basico_codigo_deposito '" & oImportacao.sValorDefault & "', " & goUsuario.iEmpresa)
                            oDataRow("deposito") = oImportacao.sValorDefault
                        Else
                            oDataRow("deposito") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                            oDataRow("codigo_deposito") = LoadCodigo("sp_select_cadastro_basico_codigo_deposito '" & oSqlDataReader.Item(oImportacao.iColuna - 1) & "', " & goUsuario.iEmpresa)
                        End If
                    Else
                        oDataRow("deposito") = DBNull.Value
                        oDataRow("codigo_deposito") = DBNull.Value
                    End If

                    'Estoque Mínimo
                    oImportacao = oLayout("estoque_minimo")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("estoque_minimo") = oImportacao.sValorDefault
                        Else
                            oDataRow("estoque_minimo") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                        End If
                    Else
                        oDataRow("estoque_minimo") = DBNull.Value
                    End If

                    'Estoque Máximo
                    oImportacao = oLayout("estoque_maximo")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("estoque_maximo") = oImportacao.sValorDefault
                        Else
                            oDataRow("estoque_maximo") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                        End If
                    Else
                        oDataRow("estoque_maximo") = DBNull.Value
                    End If

                    'Controla Lote
                    oImportacao = oLayout("controla_lote")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("controla_lote") = CBool(oImportacao.sValorDefault)
                        Else
                            oDataRow("controla_lote") = CBool(oSqlDataReader.Item(oImportacao.iColuna - 1))
                        End If
                    Else
                        oDataRow("controla_lote") = False
                    End If

                    'Percentual Desvalorização
                    oImportacao = oLayout("percentual_desvalorizacao")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("percentual_desvalorizacao") = oImportacao.sValorDefault
                        Else
                            oDataRow("percentual_desvalorizacao") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                        End If
                    Else
                        oDataRow("percentual_desvalorizacao") = DBNull.Value
                    End If

                    'Frequencia Desvalorização Dia
                    oImportacao = oLayout("frequencia_desvalorizacao_dia")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("frequencia_desvalorizacao_dia") = oImportacao.sValorDefault
                        Else
                            oDataRow("frequencia_desvalorizacao_dia") = oSqlDataReader.Item(oImportacao.iColuna - 1)
                        End If
                    Else
                        oDataRow("frequencia_desvalorizacao_dia") = DBNull.Value
                    End If

                    'Item Estoque
                    oImportacao = oLayout("item_estoque")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("item_estoque") = CBool(oImportacao.sValorDefault)
                        Else
                            oDataRow("item_estoque") = CBool(oSqlDataReader.Item(oImportacao.iColuna - 1))
                        End If
                    Else
                        oDataRow("item_estoque") = DBNull.Value
                    End If

                    'Item Compra
                    oImportacao = oLayout("item_compra")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("item_compra") = CBool(oImportacao.sValorDefault)
                        Else
                            oDataRow("item_compra") = CBool(oSqlDataReader.Item(oImportacao.iColuna - 1))
                        End If
                    Else
                        oDataRow("item_compra") = DBNull.Value
                    End If

                    'Item Venda
                    oImportacao = oLayout("item_venda")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("item_venda") = CBool(oImportacao.sValorDefault)
                        Else
                            oDataRow("item_venda") = CBool(oSqlDataReader.Item(oImportacao.iColuna - 1))
                        End If
                    Else
                        oDataRow("item_venda") = DBNull.Value
                    End If

                    'Item Ativo Fixo
                    oImportacao = oLayout("item_ativo_fixo")
                    If oImportacao.bSelecionado = True Then
                        If oImportacao.iColuna = -1 Then
                            oDataRow("item_ativo_fixo") = CBool(oImportacao.sValorDefault)
                        Else
                            oDataRow("item_ativo_fixo") = CBool(oSqlDataReader.Item(oImportacao.iColuna - 1))
                        End If
                    Else
                        oDataRow("item_ativo_fixo") = DBNull.Value
                    End If

                    'Adiciona Linha
                    oDataTable.Rows.Add(oDataRow)

                End If

            End While

            'Preenche Grid
            With oGrid

                .RootTable.Columns.Item("tipo_item").DataMember = "tipo_item"
                .RootTable.Columns.Item("codigo_tipo_item").DataMember = "codigo_tipo_item"
                .RootTable.Columns.Item("codigo_grupo_item").DataMember = "codigo_grupo_item"
                .RootTable.Columns.Item("codigo_item").DataMember = "codigo_item"
                .RootTable.Columns.Item("codigo_barras").DataMember = "codigo_barras"
                .RootTable.Columns.Item("ativo").DataMember = "ativo"
                .RootTable.Columns.Item("descricao").DataMember = "descricao"
                .RootTable.Columns.Item("descricao2").DataMember = "descricao2"
                .RootTable.Columns.Item("codigo_ncm").DataMember = "codigo_ncm"
                .RootTable.Columns.Item("peso_liquido").DataMember = "peso_liquido"
                .RootTable.Columns.Item("codigo_origem_item").DataMember = "codigo_origem_item"
                .RootTable.Columns.Item("observacao").DataMember = "observacao"
                .RootTable.Columns.Item("foto").DataMember = "foto"
                .RootTable.Columns.Item("codigo_unidade_medida_venda").DataMember = "codigo_unidade_medida_venda"
                .RootTable.Columns.Item("fator_conversao_unidade_medida_venda").DataMember = "fator_conversao_unidade_medida_venda"
                .RootTable.Columns.Item("kit").DataMember = "kit"
                .RootTable.Columns.Item("codigo_forma_venda_item").DataMember = "codigo_forma_venda_item"
                .RootTable.Columns.Item("preco_venda").DataMember = "preco_venda"
                .RootTable.Columns.Item("margem_lucro").DataMember = "margem_lucro"
                .RootTable.Columns.Item("codigo_unidade_medida_compra").DataMember = "codigo_unidade_medida_compra"
                .RootTable.Columns.Item("fator_conversao_unidade_medida_compra").DataMember = "fator_conversao_unidade_medida_compra"
                .RootTable.Columns.Item("lead_time").DataMember = "lead_time"
                .RootTable.Columns.Item("codigo_unidade_medida_estoque").DataMember = "codigo_unidade_medida_estoque"
                .RootTable.Columns.Item("codigo_deposito").DataMember = "codigo_deposito"
                .RootTable.Columns.Item("estoque_minimo").DataMember = "estoque_minimo"
                .RootTable.Columns.Item("estoque_maximo").DataMember = "estoque_maximo"
                .RootTable.Columns.Item("controla_lote").DataMember = "controla_lote"
                .RootTable.Columns.Item("percentual_desvalorizacao").DataMember = "percentual_desvalorizacao"
                .RootTable.Columns.Item("frequencia_desvalorizacao_dia").DataMember = "frequencia_desvalorizacao_dia"
                .RootTable.Columns.Item("estoque").DataMember = "item_estoque"
                .RootTable.Columns.Item("compra").DataMember = "item_compra"
                .RootTable.Columns.Item("venda").DataMember = "item_venda"
                .RootTable.Columns.Item("ativo_fixo").DataMember = "item_ativo_fixo"
                .RootTable.Columns.Item("tipo_item").DataMember = "tipo_item"
                .RootTable.Columns.Item("grupo_item").DataMember = "grupo_item"
                .RootTable.Columns.Item("ncm").DataMember = "ncm"
                .RootTable.Columns.Item("origem_item").DataMember = "origem_item"
                .RootTable.Columns.Item("unidade_medida_venda").DataMember = "unidade_medida_venda"
                .RootTable.Columns.Item("forma_venda_item").DataMember = "forma_venda_item"
                .RootTable.Columns.Item("unidade_medida_compra").DataMember = "unidade_medida_compra"
                .RootTable.Columns.Item("unidade_medida_estoque").DataMember = "unidade_medida_estoque"
                .RootTable.Columns.Item("deposito").DataMember = "deposito"

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With

        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Import(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(32) As SqlParameter
        Dim oPictureBox As New PictureBox
        Dim i As Integer
        Dim oRow() As GridEXRow = oGrid.GetDataRows

        Try

            For i = 0 To UBound(oRow)

                'Seta Parametros - Código Tipo Item
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_tipo_item"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(0).Value = oRow(i).Cells("codigo_tipo_item").Value

                'Seta Parametros - Grupo Item
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_grupo_item"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.Int
                oSqlParameter(1).Value = oRow(i).Cells("codigo_grupo_item").Value

                'Seta Parametros - Código Item
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo_item"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.VarChar
                oSqlParameter(2).Size = 60
                oSqlParameter(2).Value = oRow(i).Cells("codigo_item").Value.ToString.ToUpper

                'Seta Parametros - Código Barras
                oSqlParameter(3) = New SqlParameter
                oSqlParameter(3).ParameterName = "codigo_barras"
                oSqlParameter(3).Direction = ParameterDirection.Input
                oSqlParameter(3).SqlDbType = SqlDbType.VarChar
                oSqlParameter(3).Size = 14
                oSqlParameter(3).Value = oRow(i).Cells("codigo_barras").Value.ToString.ToUpper

                'Seta Parametros - Ativo
                oSqlParameter(4) = New SqlParameter
                oSqlParameter(4).ParameterName = "ativo"
                oSqlParameter(4).Direction = ParameterDirection.Input
                oSqlParameter(4).SqlDbType = SqlDbType.Bit
                oSqlParameter(4).Value = oRow(i).Cells("ativo").Value

                'Seta Parametros - Descrição
                oSqlParameter(5) = New SqlParameter
                oSqlParameter(5).ParameterName = "descricao"
                oSqlParameter(5).Direction = ParameterDirection.Input
                oSqlParameter(5).SqlDbType = SqlDbType.VarChar
                oSqlParameter(5).Size = 120
                oSqlParameter(5).Value = oRow(i).Cells("descricao").Value.ToString.ToUpper

                'Seta Parametros - Descrição 2
                oSqlParameter(6) = New SqlParameter
                oSqlParameter(6).ParameterName = "descricao2"
                oSqlParameter(6).Direction = ParameterDirection.Input
                oSqlParameter(6).SqlDbType = SqlDbType.VarChar
                oSqlParameter(6).Size = 500
                oSqlParameter(6).Value = oRow(i).Cells("descricao2").Value.ToString.ToUpper

                'Seta Parametros - Código NCM
                oSqlParameter(7) = New SqlParameter
                oSqlParameter(7).ParameterName = "codigo_ncm"
                oSqlParameter(7).Direction = ParameterDirection.Input
                oSqlParameter(7).SqlDbType = SqlDbType.Int
                oSqlParameter(7).Value = oRow(i).Cells("codigo_ncm").Value

                'Seta Parametros - Peso Liquido
                oSqlParameter(8) = New SqlParameter
                oSqlParameter(8).ParameterName = "peso_liquido"
                oSqlParameter(8).Direction = ParameterDirection.Input
                oSqlParameter(8).SqlDbType = SqlDbType.Float
                oSqlParameter(8).Value = oRow(i).Cells("peso_liquido").Value

                'Seta Parametros - Código Origem Item
                oSqlParameter(9) = New SqlParameter
                oSqlParameter(9).ParameterName = "codigo_origem_item"
                oSqlParameter(9).Direction = ParameterDirection.Input
                oSqlParameter(9).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(9).Value = oRow(i).Cells("codigo_origem_item").Value

                'Seta Parametros - Observação
                oSqlParameter(10) = New SqlParameter
                oSqlParameter(10).ParameterName = "observacao"
                oSqlParameter(10).Direction = ParameterDirection.Input
                oSqlParameter(10).SqlDbType = SqlDbType.Text
                oSqlParameter(10).Value = oRow(i).Cells("observacao").Value.ToString.ToUpper

                'Verifica se existe Foto
                If IsDBNull(oRow(i).Cells("foto").Value) = False Then

                    'Verifica se é existe arquivo
                    If File.Exists(oRow(i).Cells("foto").Value) = True Then

                        'Carrega Imagem
                        Dim oMemoryStream As MemoryStream = New MemoryStream()
                        Image.FromFile(oRow(i).Cells("foto").Value).Save(oMemoryStream, ImageFormat.Jpeg)
                        Dim bytBLOBData(oMemoryStream.Length - 1) As Byte
                        oMemoryStream.Position = 0
                        oMemoryStream.Read(bytBLOBData, 0, oMemoryStream.Length)

                        'Seta Parametros - Foto
                        oSqlParameter(11) = New SqlParameter
                        oSqlParameter(11).ParameterName = "foto"
                        oSqlParameter(11).Direction = ParameterDirection.Input
                        oSqlParameter(11).SqlDbType = SqlDbType.VarBinary
                        oSqlParameter(11).Value = bytBLOBData

                    Else

                        'Seta Parametros - Foto
                        oSqlParameter(11) = New SqlParameter
                        oSqlParameter(11).ParameterName = "foto"
                        oSqlParameter(11).Direction = ParameterDirection.Input
                        oSqlParameter(11).SqlDbType = SqlDbType.VarBinary
                        oSqlParameter(11).Value = DBNull.Value

                    End If

                Else

                    'Seta Parametros - Foto
                    oSqlParameter(11) = New SqlParameter
                    oSqlParameter(11).ParameterName = "foto"
                    oSqlParameter(11).Direction = ParameterDirection.Input
                    oSqlParameter(11).SqlDbType = SqlDbType.VarBinary
                    oSqlParameter(11).Value = DBNull.Value

                End If

                    'Seta Parametros - Código Unidade Medida - Venda
                    oSqlParameter(12) = New SqlParameter
                    oSqlParameter(12).ParameterName = "codigo_unidade_medida_venda"
                    oSqlParameter(12).Direction = ParameterDirection.Input
                    oSqlParameter(12).SqlDbType = SqlDbType.Int
                    oSqlParameter(12).Value = oRow(i).Cells("codigo_unidade_medida_venda").Value

                    'Seta Parametros - Fator de Conversão Unidade de Medida - Venda
                    oSqlParameter(13) = New SqlParameter
                    oSqlParameter(13).ParameterName = "fator_conversao_unidade_medida_venda"
                    oSqlParameter(13).Direction = ParameterDirection.Input
                    oSqlParameter(13).SqlDbType = SqlDbType.Float
                    oSqlParameter(13).Value = oRow(i).Cells("fator_conversao_unidade_medida_venda").Value

                    'Seta Parametros - Kit
                    oSqlParameter(14) = New SqlParameter
                    oSqlParameter(14).ParameterName = "kit"
                    oSqlParameter(14).Direction = ParameterDirection.Input
                    oSqlParameter(14).SqlDbType = SqlDbType.Bit
                    oSqlParameter(14).Value = oRow(i).Cells("kit").Value

                    'Seta Parametros - Código Forma de Venda
                    oSqlParameter(15) = New SqlParameter
                    oSqlParameter(15).ParameterName = "codigo_forma_venda_item"
                    oSqlParameter(15).Direction = ParameterDirection.Input
                    oSqlParameter(15).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(15).Value = oRow(i).Cells("codigo_forma_venda_item").Value

                    'Seta Parametros - Preço de Venda
                    oSqlParameter(16) = New SqlParameter
                    oSqlParameter(16).ParameterName = "preco_venda"
                    oSqlParameter(16).Direction = ParameterDirection.Input
                    oSqlParameter(16).SqlDbType = SqlDbType.Float
                    oSqlParameter(16).Value = oRow(i).Cells("preco_venda").Value

                    'Seta Parametros - Margem de Lucro
                    oSqlParameter(17) = New SqlParameter
                    oSqlParameter(17).ParameterName = "margem_lucro"
                    oSqlParameter(17).Direction = ParameterDirection.Input
                    oSqlParameter(17).SqlDbType = SqlDbType.Float
                    oSqlParameter(17).Value = oRow(i).Cells("margem_lucro").Value

                    'Seta Parametros - Código Unidade Medida - Compra
                    oSqlParameter(18) = New SqlParameter
                    oSqlParameter(18).ParameterName = "codigo_unidade_medida_compra"
                    oSqlParameter(18).Direction = ParameterDirection.Input
                    oSqlParameter(18).SqlDbType = SqlDbType.Int
                    oSqlParameter(18).Value = oRow(i).Cells("codigo_unidade_medida_compra").Value

                    'Seta Parametros - Fator de Conversão Unidade de Medida - Compra
                    oSqlParameter(19) = New SqlParameter
                    oSqlParameter(19).ParameterName = "fator_conversao_unidade_medida_compra"
                    oSqlParameter(19).Direction = ParameterDirection.Input
                    oSqlParameter(19).SqlDbType = SqlDbType.Float
                    oSqlParameter(19).Value = oRow(i).Cells("fator_conversao_unidade_medida_compra").Value

                    'Seta Parametros - Lead Time
                    oSqlParameter(20) = New SqlParameter
                    oSqlParameter(20).ParameterName = "lead_time"
                    oSqlParameter(20).Direction = ParameterDirection.Input
                    oSqlParameter(20).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(20).Value = oRow(i).Cells("lead_time").Value

                    'Seta Parametros - Código Depósito - Estoque
                    oSqlParameter(21) = New SqlParameter
                    oSqlParameter(21).ParameterName = "codigo_deposito"
                    oSqlParameter(21).Direction = ParameterDirection.Input
                    oSqlParameter(21).SqlDbType = SqlDbType.Int
                    oSqlParameter(21).Value = oRow(i).Cells("codigo_deposito").Value

                    'Seta Parametros - Código Unidade Medida - Estoque
                    oSqlParameter(22) = New SqlParameter
                    oSqlParameter(22).ParameterName = "codigo_unidade_medida_estoque"
                    oSqlParameter(22).Direction = ParameterDirection.Input
                    oSqlParameter(22).SqlDbType = SqlDbType.Int
                    oSqlParameter(22).Value = oRow(i).Cells("codigo_unidade_medida_estoque").Value

                    'Seta Parametros - Estoque Mínimo
                    oSqlParameter(23) = New SqlParameter
                    oSqlParameter(23).ParameterName = "estoque_minimo"
                    oSqlParameter(23).Direction = ParameterDirection.Input
                    oSqlParameter(23).SqlDbType = SqlDbType.Float
                    oSqlParameter(23).Value = oRow(i).Cells("estoque_minimo").Value

                    'Seta Parametros - Estoque Máximo
                    oSqlParameter(24) = New SqlParameter
                    oSqlParameter(24).ParameterName = "estoque_maximo"
                    oSqlParameter(24).Direction = ParameterDirection.Input
                    oSqlParameter(24).SqlDbType = SqlDbType.Float
                    oSqlParameter(24).Value = oRow(i).Cells("estoque_maximo").Value

                    'Seta Parametros - Controla Lote
                    oSqlParameter(25) = New SqlParameter
                    oSqlParameter(25).ParameterName = "controla_lote"
                    oSqlParameter(25).Direction = ParameterDirection.Input
                    oSqlParameter(25).SqlDbType = SqlDbType.Bit
                    oSqlParameter(25).Value = oRow(i).Cells("controla_lote").Value

                    'Seta Parametros - Percentual de Desvalorização
                    oSqlParameter(26) = New SqlParameter
                    oSqlParameter(26).ParameterName = "percentual_desvalorizacao"
                    oSqlParameter(26).Direction = ParameterDirection.Input
                    oSqlParameter(26).SqlDbType = SqlDbType.Float
                    oSqlParameter(26).Value = oRow(i).Cells("percentual_desvalorizacao").Value

                    'Seta Parametros - Frequencia de Desvalorização (dia)
                    oSqlParameter(27) = New SqlParameter
                    oSqlParameter(27).ParameterName = "frequencia_desvalorizacao_dia"
                    oSqlParameter(27).Direction = ParameterDirection.Input
                    oSqlParameter(27).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(27).Value = oRow(i).Cells("frequencia_desvalorizacao_dia").Value

                    'Seta Parametros - Estoque
                    oSqlParameter(28) = New SqlParameter
                    oSqlParameter(28).ParameterName = "item_estoque"
                    oSqlParameter(28).Direction = ParameterDirection.Input
                    oSqlParameter(28).SqlDbType = SqlDbType.Bit
                    oSqlParameter(28).Value = oRow(i).Cells("estoque").Value

                    'Seta Parametros - Compra
                    oSqlParameter(29) = New SqlParameter
                    oSqlParameter(29).ParameterName = "item_compra"
                    oSqlParameter(29).Direction = ParameterDirection.Input
                    oSqlParameter(29).SqlDbType = SqlDbType.Bit
                    oSqlParameter(29).Value = oRow(i).Cells("compra").Value

                    'Seta Parametros - Venda
                    oSqlParameter(30) = New SqlParameter
                    oSqlParameter(30).ParameterName = "item_venda"
                    oSqlParameter(30).Direction = ParameterDirection.Input
                    oSqlParameter(30).SqlDbType = SqlDbType.Bit
                    oSqlParameter(30).Value = oRow(i).Cells("venda").Value

                    'Seta Parametros - Ativo Fixo
                    oSqlParameter(31) = New SqlParameter
                    oSqlParameter(31).ParameterName = "item_ativo_fixo"
                    oSqlParameter(31).Direction = ParameterDirection.Input
                    oSqlParameter(31).SqlDbType = SqlDbType.Bit
                    oSqlParameter(31).Value = oRow(i).Cells("ativo_fixo").Value

                    'Seta Parametros - Código Empresa
                    oSqlParameter(32) = New SqlParameter
                    oSqlParameter(32).ParameterName = "codigo_empresa"
                    oSqlParameter(32).Direction = ParameterDirection.Input
                    oSqlParameter(32).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(32).Value = goUsuario.iEmpresa

                    'Executa Query
                    ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_integracao_importacao_item", oSqlParameter)

            Next i

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
