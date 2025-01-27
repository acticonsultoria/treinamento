Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrQAInspecaoEtiqueta

#Region "::: FUNCTION / SUB :::"

#Region "::: QUALIDADE :::"

    Public Sub LoadDados(ByVal lCodigoEntradaCapa As Long, _
                         ByVal iCodigoEntradaItem As Integer, _
                         ByVal txtProduto As MaskedEditBox, _
                         ByVal txtLote As MaskedEditBox, _
                         ByVal txtNotaFiscal As MaskedEditBox, _
                         ByVal txtPedidoCompra As MaskedEditBox, _
                         ByVal txtFornecedor As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_capa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoEntradaCapa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_entrada_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoEntradaItem

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_qualidade_inspecao_etiqueta_dados", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    'Carrega Controles
                    txtProduto.Text = oSqlDataReader.Item("produto")
                    txtNotaFiscal.Text = oSqlDataReader.Item("nota_fiscal")
                    txtLote.Text = oSqlDataReader.Item("lote")
                    txtPedidoCompra.Text = oSqlDataReader.Item("pedido_compra")
                    txtFornecedor.Text = oSqlDataReader.Item("fornecedor")

                End While

            End If

            'Fecha o DataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
