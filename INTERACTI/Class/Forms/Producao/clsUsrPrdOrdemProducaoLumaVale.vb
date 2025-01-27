Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrPrdOrdemProducaoLumaVale

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String, _
                        ByVal sOrdemProducao As String, _
                        ByVal sNumeroRequisicao As String, _
                        ByVal sCodigoProdutoSaida As String, _
                        ByVal sDescricaoProdutoSaida As String, _
                        ByVal sCodigoProdutoEntrada As String, _
                        ByVal sDescricaoProdutoEntrada As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

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
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1

            'Seta Parametros - Número do Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ordem_producao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sOrdemProducao : i += 1

            'Seta Parametros - Número do Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_requisicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = sNumeroRequisicao : i += 1

            'Seta Parametros - Número do Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_produto_saida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sCodigoProdutoSaida : i += 1

            'Seta Parametros - Número do Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao_produto_saida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricaoProdutoSaida : i += 1

            'Seta Parametros - Número do Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_produto_entrada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sCodigoProdutoEntrada : i += 1

            'Seta Parametros - Número do Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descricao_produto_entrada"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sDescricaoProdutoEntrada : i += 1

            'Seta Parametros - Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_producao_ordem_producao_lumavale", oSqlParameter)

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

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal lCodigoItem As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_estoque_movimentacao2", oSqlParameter)

            Call ConfigurarDataMemberGrid(oGrid)
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InserirMovimentacao(ByVal oGrid As GridEX, _
                                   ByVal sCodigoProduto As String, _
                                   ByVal iCodigoItem As Integer, _
                                   ByVal sDescricao As String, _
                                   ByVal sLote As String, _
                                   ByVal sDeposito As String, _
                                   ByVal iCodigoDeposito As Integer, _
                                   ByVal dQuantidade As Double)

        Try

            'Váriaveis Locais
            Dim oRow As GridEXRow

            'Caso Valor Liquido maior que 0
            If dQuantidade > 0 Then

                'Variaveis Locais
                Dim oDataSet As New DataSet

                If oGrid.RecordCount = 0 Then



                    Dim oDataTable As New DataTable
                    Dim oDCCodigoProduto As New DataColumn("codigo_produto")
                    Dim oDCCodigoItem As New DataColumn("codigo_item")
                    Dim oDCDescricao As New DataColumn("descricao")
                    Dim oDCLote As New DataColumn("lote")
                    Dim oDCDeposito As New DataColumn("deposito")
                    Dim oDCCodigoDeposito As New DataColumn("codigo_deposito")
                    Dim oDCQuantidade As New DataColumn("quantidade")

                    'Seta DataType
                    oDCQuantidade.DataType = 0.0.GetType

                    'Adiciona Tabela ao DataSet
                    oDataSet.Tables.Add(oDataTable)

                    'Adiciona Colunas ao DataTable
                    oDataTable.Columns.Add(oDCCodigoProduto)
                    oDataTable.Columns.Add(oDCCodigoItem)
                    oDataTable.Columns.Add(oDCDescricao)
                    oDataTable.Columns.Add(oDCLote)
                    oDataTable.Columns.Add(oDCDeposito)
                    oDataTable.Columns.Add(oDCCodigoDeposito)
                    oDataTable.Columns.Add(oDCQuantidade)

                Else
                    oDataSet = CType(oGrid.DataSource.dataset, DataSet).Copy

                End If

                'Adiciona Linhas ao DataTable
                Dim oDataRow As DataRow = oDataSet.Tables(0).Rows.Add
                oDataRow("codigo_produto") = sCodigoProduto
                oDataRow("codigo_item") = iCodigoItem
                oDataRow("descricao") = sDescricao
                oDataRow("lote") = sLote
                oDataRow("deposito") = sDeposito
                oDataRow("codigo_deposito") = iCodigoDeposito
                oDataRow("quantidade") = dQuantidade



                'Configura DataMember
                Call ConfigurarDataMemberGrid(oGrid)

                'Carrega Grid
                oGrid.DataSource = oDataSet.DefaultViewManager
                oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            Else

                'Limpa Grid
                oGrid.DataSource = Nothing

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteMovimentacao(ByVal oGrid As GridEX, _
                                   ByVal iCodigoProduto As Integer, _
                                   ByVal sDescricao As String, _
                                   ByVal sLote As String, _
                                   ByVal sDeposito As String, _
                                   ByVal dQuantidade As Double)

        Try

            'Váriaveis Locais
            Dim oRow As GridEXRow

            'Caso Valor Liquido maior que 0
            If dQuantidade > 0 Then

                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDCCodigoProduto As New DataColumn("codigo_produto")
                Dim oDCDescricao As New DataColumn("descricao")
                Dim oDCLote As New DataColumn("lote")
                Dim oDCDeposito As New DataColumn("deposito")
                Dim oDCQuantidade As New DataColumn("quantidade")

                'Seta DataType
                oDCQuantidade.DataType = 0.0.GetType

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Remove(oDataTable)

                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Remove(oDCCodigoProduto)
                oDataTable.Columns.Remove(oDCDescricao)
                oDataTable.Columns.Remove(oDCLote)
                oDataTable.Columns.Remove(oDCDeposito)
                oDataTable.Columns.Remove(oDCQuantidade)

                'Adiciona Linhas ao DataTable
                'Dim oDataRow As DataRow = oDataSet.Tables(0).Rows.Remove(oDataTable)



                'Configura DataMember
                Call ConfigurarDataMemberGrid(oGrid)

                'Carrega Grid
                oGrid.DataSource = oDataSet.DefaultViewManager
                oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            Else

                'Limpa Grid
                oGrid.DataSource = Nothing

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub SalvarMovimentacao(ByVal oGrid As GridEX, _
                          ByVal iCodigo As Integer, _
                          ByVal iCodigoProduto As Integer, _
                          ByVal sLote As String, _
                          ByVal iCodigoDeposito As Integer, _
                          ByVal iQuantidade As Integer)

        'Variaveis Locais        
        Dim i As Integer
        Dim oRow() As GridEXRow
        Dim oSqlParameter(5) As SqlParameter

        Try

            oRow = oGrid.GetDataRows

            For i = 0 To UBound(oRow)

                'Seta Parametros 
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).Value = iCodigo

                'Seta Parametros 
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_item"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.Int
                oSqlParameter(1).Value = oRow(i).Cells("codigo_item").Value

                'Seta Parametros 
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "lote"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.VarChar
                oSqlParameter(2).Size = 50
                oSqlParameter(2).Value = IIf(oRow(i).Cells("lote").Value = "", DBNull.Value, oRow(i).Cells("lote").Value)

                'Seta Parametros
                oSqlParameter(3) = New SqlParameter
                oSqlParameter(3).ParameterName = "codigo_deposito"
                oSqlParameter(3).Direction = ParameterDirection.Input
                oSqlParameter(3).SqlDbType = SqlDbType.Int
                oSqlParameter(3).Value = oRow(i).Cells("codigo_deposito").Value

                'Seta Parametros - Quantidade
                oSqlParameter(4) = New SqlParameter
                oSqlParameter(4).ParameterName = "quantidade"
                oSqlParameter(4).Direction = ParameterDirection.Input
                oSqlParameter(4).SqlDbType = SqlDbType.Int
                oSqlParameter(4).Value = oRow(i).Cells("quantidade").Value

                'Seta Parametros - Código Empresa
                oSqlParameter(5) = New SqlParameter
                oSqlParameter(5).ParameterName = "codigo_empresa"
                oSqlParameter(5).Direction = ParameterDirection.Input
                oSqlParameter(5).SqlDbType = SqlDbType.Int
                oSqlParameter(5).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_estoque_movimentacao_entrada_lote", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete()

        'Variaveis Locais        
        Dim i As Integer
        Dim oSqlParameter(2) As SqlParameter

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros 
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_ordem_producao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).Value = oRow.Cells("codigo_ordem_producao").Value : i += 1

                'Seta Parametros 
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_requisicao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).Value = oRow.Cells("codigo_requisicao").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_producao_ordem_producao_lumavale", oSqlParameter)

                'Deleta Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


#End Region

End Class
