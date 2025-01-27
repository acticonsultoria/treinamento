Imports System.Data
Imports System.Data.SqlClient
Imports SysACTi.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop.Excel

Public Class clsUsrCmpRelatorioPedido

#Region "::: FUNCTION / SUB :::"



    Public Sub LoadGridListagem(ByVal oGrid As GridEX, _
                                ByVal sDataInicio As String, _
                                ByVal sDataFim As String, _
                                ByVal sItem As String, _
                                ByVal iForncedor As Integer, _
                                ByVal iNivel As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros - Data Início
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "data_inicio"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Date
            oSqlParameter(0).Value = IIf(sDataInicio = "", DBNull.Value, (sDataInicio))

            'Seta Parametros - Data Fim
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_fim"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Date
            oSqlParameter(1).Value = IIf(sDataFim = "", DBNull.Value, (sDataFim))

            'Seta Parametros - Item
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "item"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Value = sItem

            'Seta Parametros - Código Fornecedor
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_fornecedor"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iForncedor


            'Seta Parametros - Nível
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "nivel"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Int
            oSqlParameter(4).Value = iNivel


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_relatorio_pedido", oSqlParameter)

            With oGrid
                .RootTable.Columns.Item("part_number").DataMember = "part_number"
                .RootTable.Columns.Item("item").DataMember = "item"
                .RootTable.Columns.Item("prioridade_abc").DataMember = "prioridade_abc"


                .RootTable.Columns.Item("numero_requisicao").DataMember = "numero_requisicao"
                .RootTable.Columns.Item("aprovador").DataMember = "aprovador"
                .RootTable.Columns.Item("requisitante").DataMember = "requisitante"

                .RootTable.Columns.Item("qtd_requisicao").DataMember = "qtd_requisicao"
                .RootTable.Columns.Item("centro_custo").DataMember = "centro_custo"
                .RootTable.Columns.Item("unidade_medida").DataMember = "unidade_medida"
                .RootTable.Columns.Item("utilizacao_item").DataMember = "utilizacao_item"
                .RootTable.Columns.Item("justificativa").DataMember = "justificativa"
                .RootTable.Columns.Item("data_requisicao").DataMember = "data_requisicao"
                .RootTable.Columns.Item("data_previsao_requisicao").DataMember = "data_previsao_requisicao"
                .RootTable.Columns.Item("numero_cotacao").DataMember = "numero_cotacao"
                .RootTable.Columns.Item("prazo").DataMember = "prazo"
                .RootTable.Columns.Item("status").DataMember = "status"
                .RootTable.Columns.Item("numero_pedido").DataMember = "numero_pedido"
                .RootTable.Columns.Item("status_pedido").DataMember = "status_pedido"
                .RootTable.Columns.Item("fornecedor").DataMember = "fornecedor"
                .RootTable.Columns.Item("qtd_pedido").DataMember = "qtd_pedido"
                .RootTable.Columns.Item("qtd_entregue").DataMember = "qtd_entregue"
                .RootTable.Columns.Item("qtd_cancelada").DataMember = "qtd_cancelada"
                .RootTable.Columns.Item("qtd_pendente").DataMember = "qtd_pendente"
                .RootTable.Columns.Item("valor_unitario").DataMember = "valor_unitario"
                .RootTable.Columns.Item("valor_total").DataMember = "valor_total"
                .RootTable.Columns.Item("ipi_incluso").DataMember = "ipi_incluso"
                .RootTable.Columns.Item("icms_incluso").DataMember = "icms_incluso"
                .RootTable.Columns.Item("data_cancelamento").DataMember = "data_cancelamento"
                .RootTable.Columns.Item("motivo_cancelamento").DataMember = "motivo_cancelamento"
                .RootTable.Columns.Item("data_pedido").DataMember = "data_pedido"
                .RootTable.Columns.Item("moeda").DataMember = "moeda"
                .RootTable.Columns.Item("nota_fiscal").DataMember = "nota_fiscal"
                .RootTable.Columns.Item("data_recebimento").DataMember = "data_recebimento"
                .RootTable.Columns.Item("forma_pagamento").DataMember = "forma_pagamento"
                .RootTable.Columns.Item("condicao_pagamento").DataMember = "condicao_pagamento"
                .RootTable.Columns.Item("transportadora").DataMember = "transportadora"
                .RootTable.Columns.Item("observacao_aprovacao").DataMember = "observacao_aprovacao"
                .RootTable.Columns.Item("ipi").DataMember = "ipi"
                .RootTable.Columns.Item("icms").DataMember = "icms"
                .RootTable.Columns.Item("importada").DataMember = "importada"

                .RootTable.Columns.Item("fornecedor1").DataMember = "fornecedor1"
                .RootTable.Columns.Item("moeda1").DataMember = "moeda1"
                .RootTable.Columns.Item("valor1").DataMember = "valor1"
                .RootTable.Columns.Item("prazo1").DataMember = "prazo1"
                .RootTable.Columns.Item("condicao1").DataMember = "condicao1"

                .RootTable.Columns.Item("fornecedor2").DataMember = "fornecedor2"
                .RootTable.Columns.Item("moeda2").DataMember = "moeda2"
                .RootTable.Columns.Item("valor2").DataMember = "valor2"
                .RootTable.Columns.Item("prazo2").DataMember = "prazo2"
                .RootTable.Columns.Item("condicao2").DataMember = "condicao2"



                .RootTable.Columns.Item("data_emissao").DataMember = "data_emissao"
                .RootTable.Columns.Item("data_recebimento").DataMember = "data_recebimento"

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

