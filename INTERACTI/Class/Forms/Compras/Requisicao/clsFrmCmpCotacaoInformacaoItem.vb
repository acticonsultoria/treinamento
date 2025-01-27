Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper

Public Class clsFrmCmpCotacaoInformacaoItem

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadDados(ByVal lCotacaoLinha As Long, _
                         ByVal lblFornecedor As Label, _
                         ByVal lblPartNumber As Label, _
                         ByVal lblDescricao As Label, _
                         ByVal lblMarca As Label, _
                         ByVal lblQuantidade As Label, _
                         ByVal lblUnidadeMedida As Label, _
                         ByVal lblFatorConversao As Label, _
                         ByVal lblQuantidadeUnidade As Label, _
                         ByVal lblValorUnitario As Label, _
                         ByVal lblImpostoAgregado As Label, _
                         ByVal lblIPI As Label, _
                         ByVal lblICMS As Label, _
                         ByVal lblDesconto As Label, _
                         ByVal lblValorUnitarioFinal As Label, _
                         ByVal lblValorTotal As Label, _
                         ByVal lblMoeda As Label, _
                         ByVal lblDataNecessidade As Label, _
                         ByVal lblPrazoEntrega As Label, _
                         ByVal lblValorUltimaCompra As Label, _
                         ByVal lblDataUltimaCompra As Label, _
                         ByVal lblFornecedorUltimaCompra As Label, _
                         ByVal lblValorMelhorCompra As Label, _
                         ByVal lblDataMelhorCompra As Label, _
                         ByVal lblFornecedorMelhorCompra As Label)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter

        Try

            'Seta Parametros - Número da Requisição
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_cotacao_fornecedor_linha"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCotacaoLinha

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_cotacao_historico_item", oSqlParameter)

            While oSqlDataReader.Read

                lblFornecedor.Text = oSqlDataReader.Item("fornecedor")
                lblPartNumber.Text = oSqlDataReader.Item("part_number")
                lblDescricao.Text = oSqlDataReader.Item("descricao")
                lblMarca.Text = oSqlDataReader.Item("marca")
                lblQuantidade.Text = FormatNumber(oSqlDataReader.Item("quantidade"), 2, TriState.True)
                lblUnidadeMedida.Text = oSqlDataReader.Item("unidade_medida")
                lblFatorConversao.Text = FormatNumber(oSqlDataReader.Item("fator_conversao_unidade_medida"), 2, TriState.True)
                lblQuantidadeUnidade.Text = FormatNumber(oSqlDataReader.Item("quantidade_unidade"), 2, TriState.True)
                lblValorUnitario.Text = "R$ " & FormatNumber(oSqlDataReader.Item("valor_unitario"), 2, TriState.True)
                lblImpostoAgregado.Text = IIf(oSqlDataReader.Item("imposto_agregado") = False, "NÃO", "SIM")
                lblIPI.Text = FormatNumber(oSqlDataReader.Item("ipi"), 2, TriState.True)
                lblICMS.Text = FormatNumber(oSqlDataReader.Item("icms"), 2, TriState.True)
                lblDesconto.Text = FormatNumber(oSqlDataReader.Item("porcentagem_desconto"), 2, TriState.True)
                lblValorUnitarioFinal.Text = "R$ " & FormatNumber(oSqlDataReader.Item("valor_unitario_final"), 2, TriState.True)
                lblValorTotal.Text = "R$ " & FormatNumber(oSqlDataReader.Item("valor_total"), 2, TriState.True)
                lblMoeda.Text = oSqlDataReader.Item("moeda")
                lblDataNecessidade.Text = oSqlDataReader.Item("data_necessidade")
                lblPrazoEntrega.Text = oSqlDataReader.Item("prazo_entrega")
                If (oSqlDataReader.Item("data_necessidade") < oSqlDataReader.Item("prazo_entrega")) Then
                    lblPrazoEntrega.ForeColor = Color.Red
                End If

                Dim sUltimaCompra() As String
                sUltimaCompra = oSqlDataReader.Item("ultima_compra").ToString.Split("|")
                If sUltimaCompra(0) <> "" Then
                    lblValorUltimaCompra.Text = "R$ " & FormatNumber(CDbl(sUltimaCompra(0)), 2, TriState.True)
                    lblDataUltimaCompra.Text = Format(CDate(sUltimaCompra(1)), "dd/MM/yyyy")
                    lblFornecedorUltimaCompra.Text = sUltimaCompra(2)
                End If
                'lblValorMelhorCompra.Text = oSqlDataReader.Item("valor_melhor_compra")
                'lblDataMelhorCompra.Text = oSqlDataReader.Item("data_melhor_compra")
                'lblFornecedorMelhorCompra.Text = oSqlDataReader.Item("fornecedor_melhor_compra")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class
