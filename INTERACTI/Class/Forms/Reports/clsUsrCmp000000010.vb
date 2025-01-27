Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX

Public Class clsUsrCmp000000010

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal dPolitica As Double, _
                        ByVal bConsiderarPedidoVenda As Boolean, _
                        ByVal sRevisao As String, _
                        ByVal sProduto As String, _
                        ByVal iCodigoGrupoItem As Integer, _
                        ByVal iCodigoMaterial As Integer, _
                        ByVal iCodigoDiametro As Integer, _
                        ByVal iCodigoTamanhoAgulha As Integer, _
                        ByVal iCodigoFormatoAgulha As Integer, _
                        ByVal iCodigoBitola As Integer, _
                        ByVal iCodigoEspecialidade As Integer, _
                        ByVal iCodigoMarca As Integer, _
                        ByVal iCodigoCor As Integer, _
                        ByVal iCodigoUnidadeMedida As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(15) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Politica
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "politica"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPolitica : i += 1

            'Seta Parametros - Considerar Pedido Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "considerar_pedido_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bConsiderarPedidoVenda : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Revisão
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "revisao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sRevisao : i += 1

            'Seta Parametros - Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sProduto : i += 1

            'Seta Parametros - Código Grupo do Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoGrupoItem : i += 1

            'Seta Parametros - Código Material
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_material"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoMaterial : i += 1

            'Seta Parametros - Código Diâmetro
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_diametro"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoDiametro : i += 1

            'Seta Parametros - Código Tamanho Agulha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tamanho_agulha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoTamanhoAgulha : i += 1

            'Seta Parametros - Código Formato Agulha
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_formato_agulha"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFormatoAgulha : i += 1

            'Seta Parametros - Código Bitola
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_bitola"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoBitola : i += 1

            'Seta Parametros - Código Especialidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_especialidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEspecialidade : i += 1

            'Seta Parametros - Código Marca
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_marca"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoMarca : i += 1

            'Seta Parametros - Código Cor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCor : i += 1

            'Seta Parametros - Código Unidade Medida Referencia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedida

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_grid_cmp000000010", oSqlParameter)

            'Configura DataMember Grid
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

    Public Sub LoadGridPedidoCompra(ByVal oGrid As GridEX)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDCMarca As New DataColumn("marca")
            Dim oDCCodigProduto As New DataColumn("codigo_produto")
            Dim oDCDescricao As New DataColumn("descricao")
            Dim oDCReferencia As New DataColumn("referencia")
            Dim oDCQuantidadeEstoque As New DataColumn("quantidade_estoque")
            Dim oDCEstoqueMinimo As New DataColumn("estoque_minimo")
            Dim oDCPedidoCompra As New DataColumn("pedido_compra")
            Dim oDCPedidoVenda As New DataColumn("pedido_venda")
            Dim oDCNecessidade As New DataColumn("necessidade")
            Dim oDCUnidadeMedida As New DataColumn("unidade_medida")
            Dim oDCDataPrevisaoEntrega As New DataColumn("data_previsao_entrega")
            Dim oDCValorUnitario As New DataColumn("valor_unitario")
            Dim oDCICMSEmbutido As New DataColumn("icms_embutido")
            Dim oDCAliquotaICMS As New DataColumn("aliquota_icms")
            Dim oDCValorICMS As New DataColumn("valor_icms")
            Dim oDCIPIEmbutido As New DataColumn("ipi_embutido")
            Dim oDCAliquotaIPI As New DataColumn("aliquota_ipi")
            Dim oDCValorIPI As New DataColumn("valor_ipi")
            Dim oDCPISCOFINSEmbutido As New DataColumn("pis_cofins_embutido")
            Dim oDCAliquotaPISCOFINS As New DataColumn("aliquota_pis_cofins")
            Dim oDCValorPISCOFINS As New DataColumn("valor_pis_cofins")
            Dim oDCPrecoCompra As New DataColumn("preco_compra")
            Dim oDCTotalCompra As New DataColumn("preco_total")
            Dim oDCCustoTeorico As New DataColumn("custo_teorico")
            Dim oDCMultiploCompra As New DataColumn("multiplo_compra")
            Dim oDCPedidoMinimo As New DataColumn("pedido_minimo")
            Dim oDCNumeroOrcamentosVendas As New DataColumn("numero_orcamentos_vendas")
            Dim oDCCodigoCentroCusto As New DataColumn("codigo_centro_custo")
            Dim oDCCodigoUnidadeMedida As New DataColumn("codigo_unidade_medida")
            Dim oDCContaContabil As New DataColumn("conta_contabil")
            Dim oDCCodigo As New DataColumn("codigo")

            'Seta DataType
            oDCQuantidadeEstoque.DataType = 0.0.GetType
            oDCEstoqueMinimo.DataType = 0.0.GetType
            oDCPedidoCompra.DataType = 0.0.GetType
            oDCPedidoVenda.DataType = 0.0.GetType
            oDCNecessidade.DataType = 0.0.GetType
            oDCDataPrevisaoEntrega.DataType = Now.Date.GetType
            oDCValorUnitario.DataType = 0.0.GetType
            oDCPrecoCompra.DataType = 0.0.GetType
            oDCTotalCompra.DataType = 0.0.GetType
            oDCCustoTeorico.DataType = 0.0.GetType
            oDCMultiploCompra.DataType = 0.0.GetType
            oDCPedidoMinimo.DataType = 0.0.GetType
            oDCICMSEmbutido.DataType = False.GetType
            oDCAliquotaICMS.DataType = 0.0.GetType
            oDCValorICMS.DataType = 0.0.GetType
            oDCIPIEmbutido.DataType = False.GetType
            oDCAliquotaIPI.DataType = 0.0.GetType
            oDCValorIPI.DataType = 0.0.GetType
            oDCPISCOFINSEmbutido.DataType = False.GetType
            oDCAliquotaPISCOFINS.DataType = 0.0.GetType
            oDCValorPISCOFINS.DataType = 0.0.GetType

            'Adiciona Tabela ao DataSet
            oDataSet.Tables.Add(oDataTable)

            'Adiciona Colunas ao DataTable
            oDataTable.Columns.Add(oDCMarca)
            oDataTable.Columns.Add(oDCCodigProduto)
            oDataTable.Columns.Add(oDCDescricao)
            oDataTable.Columns.Add(oDCReferencia)
            oDataTable.Columns.Add(oDCQuantidadeEstoque)
            oDataTable.Columns.Add(oDCEstoqueMinimo)
            oDataTable.Columns.Add(oDCPedidoCompra)
            oDataTable.Columns.Add(oDCPedidoVenda)
            oDataTable.Columns.Add(oDCNecessidade)
            oDataTable.Columns.Add(oDCUnidadeMedida)
            oDataTable.Columns.Add(oDCDataPrevisaoEntrega)
            oDataTable.Columns.Add(oDCValorUnitario)
            oDataTable.Columns.Add(oDCICMSEmbutido)
            oDataTable.Columns.Add(oDCAliquotaICMS)
            oDataTable.Columns.Add(oDCValorICMS)
            oDataTable.Columns.Add(oDCIPIEmbutido)
            oDataTable.Columns.Add(oDCAliquotaIPI)
            oDataTable.Columns.Add(oDCValorIPI)
            oDataTable.Columns.Add(oDCPISCOFINSEmbutido)
            oDataTable.Columns.Add(oDCAliquotaPISCOFINS)
            oDataTable.Columns.Add(oDCValorPISCOFINS)
            oDataTable.Columns.Add(oDCTotalCompra)
            oDataTable.Columns.Add(oDCPrecoCompra)
            oDataTable.Columns.Add(oDCCustoTeorico)
            oDataTable.Columns.Add(oDCMultiploCompra)
            oDataTable.Columns.Add(oDCPedidoMinimo)
            oDataTable.Columns.Add(oDCNumeroOrcamentosVendas)
            oDataTable.Columns.Add(oDCCodigoCentroCusto)
            oDataTable.Columns.Add(oDCContaContabil)
            oDataTable.Columns.Add(oDCCodigoUnidadeMedida)
            oDataTable.Columns.Add(oDCCodigo)

            For Each oRow As GridEXRow In gSelecaoRow
                Dim oDataRow As DataRow = oDataTable.NewRow
                oDataRow("marca") = oRow.Cells("marca").Value
                oDataRow("codigo_produto") = oRow.Cells("codigo_produto").Value
                oDataRow("descricao") = oRow.Cells("descricao").Value
                oDataRow("referencia") = oRow.Cells("referencia").Value
                oDataRow("quantidade_estoque") = oRow.Cells("quantidade_estoque").Value
                oDataRow("estoque_minimo") = oRow.Cells("estoque_minimo").Value
                oDataRow("pedido_compra") = oRow.Cells("pedido_compra").Value
                oDataRow("pedido_venda") = oRow.Cells("pedido_venda").Value
                oDataRow("necessidade") = oRow.Cells("necessidade").Value
                oDataRow("unidade_medida") = oRow.Cells("unidade_medida").Value
                oDataRow("data_previsao_entrega") = DBNull.Value
                oDataRow("valor_unitario") = oRow.Cells("valor_compra").Value
                oDataRow("icms_embutido") = True
                oDataRow("aliquota_icms") = 0
                oDataRow("valor_icms") = 0
                oDataRow("ipi_embutido") = False
                oDataRow("aliquota_ipi") = 0
                oDataRow("valor_ipi") = 0
                oDataRow("pis_cofins_embutido") = True
                oDataRow("aliquota_pis_cofins") = 0
                oDataRow("valor_pis_cofins") = 0
                oDataRow("preco_compra") = oRow.Cells("valor_compra").Value
                oDataRow("preco_total") = oRow.Cells("total_compra").Value
                oDataRow("custo_teorico") = oRow.Cells("custo_teorico").Value
                oDataRow("multiplo_compra") = oRow.Cells("multiplo_compra").Value
                oDataRow("pedido_minimo") = oRow.Cells("pedido_minimo").Value
                oDataRow("numero_orcamentos_vendas") = oRow.Cells("numero_orcamentos_vendas").Value
                oDataRow("codigo_centro_custo") = DBNull.Value
                oDataRow("conta_contabil") = DBNull.Value
                oDataRow("codigo") = oRow.Cells("codigo").Value
                oDataRow("codigo_unidade_medida") = oRow.Cells("codigo_unidade_medida").Value
                oDataTable.Rows.Add(oDataRow)
            Next

            'Configura DataMember Grid
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

#End Region

End Class
