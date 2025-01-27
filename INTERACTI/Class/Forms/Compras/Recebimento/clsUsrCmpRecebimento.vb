Imports System.Data
Imports System.Data.SqlClient
Imports Janus.Windows.GridEX
Imports INTERACTI.SQLHelper

Public Class clsUsrCmpRecebimento

#Region "::: FUNCTION / SUB :::"

#Region "::: RECEBIMENTO :::"

    Public Sub LoadGridRecebimento(ByVal oGrid As GridEX, _
                                   ByVal sNumeroDocumento As String, _
                                   ByVal sDataInicio As String, _
                                   ByVal sDataTermino As String, _
                                   ByVal sFornecedor As String, _
                                   ByVal lNumeroPedido As Long, _
                                   ByVal iCodigoTipoItem As Integer, _
                                   ByVal sItem As String)

        'Variaveis Locais
        Dim oSqlParameter(7) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Nº Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

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

            'Seta Parametros - Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sFornecedor.Trim : i += 1

            'Seta Parametros - Número do Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNumeroPedido : i += 1

            'Seta Parametros - Código Tipo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoItem : i += 1

            'Seta Parametros - Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sItem.Trim : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_recebimento", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo_recebimento"))

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

    Public Sub InsertRecebimento(ByVal sNumeroDocumento As String, _
                                 ByVal sData As String, _
                                 ByVal iCodigoFornecedor As Integer, _
                                 ByRef lCodigoRecebimento As Long)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recebimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recebimento"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt : i += 1

            'Seta Parametros - Nº Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

            'Seta Parametros - Data
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sData : i += 1

            'Seta Parametros - Código Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFornecedor : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código de Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_recebimento", oSqlParameter)

            'Seta Váriavel
            lCodigoRecebimento = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateRecebimento(ByVal sNumeroDocumento As String, _
                                 ByVal sData As String, _
                                 ByVal iCodigoFornecedor As Integer, _
                                 ByVal lCodigoRecebimento As Long)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recebimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recebimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRecebimento : i += 1

            'Seta Parametros - Nº Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroDocumento : i += 1

            'Seta Parametros - Data
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sData : i += 1

            'Seta Parametros - Código Fornecedor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoFornecedor : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Código de Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_recebimento", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteRecebimento()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

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
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_compras_recebimento", oSqlParameter)

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

#Region "::: ITENS :::"

    Public Sub InsertRecebimentoItem(ByVal lCodigoRecebimento As Long, _
                                     ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(6) As SqlParameter
        Dim oRow As GridEXRow
        Dim i As Integer = 0

        Try

            For Each oRow In oGrid.GetDataRows

                If oRow.Cells("quantidade_recebida").Value > 0 Then

                    'Seta Váriavel
                    i = 0

                    'Seta Parametros - Código Recebimento
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_recebimento"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(i).Value = lCodigoRecebimento : i += 1

                    'Seta Parametros - Código Pedido
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_pedido"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(i).Value = oRow.Cells("codigo_pedido").Value : i += 1

                    'Seta Parametros - Código Pedido Item
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_pedido_item"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = oRow.Cells("codigo_pedido_item").Value : i += 1

                    'Seta Parametros - Código Pedido Item Entrega
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_pedido_item_entrega"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = oRow.Cells("codigo_pedido_item_entrega").Value : i += 1

                    'Seta Parametros - Quantidade
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "quantidade"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.Float
                    oSqlParameter(i).Value = oRow.Cells("quantidade_recebida").Value : i += 1

                    'Seta Parametros - Código Recebimento Item
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo"
                    oSqlParameter(i).Direction = ParameterDirection.Output
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt : i += 1

                    'Seta Parametros - Código de Empresa
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_empresa"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = goUsuario.iEmpresa

                    'Executa Query
                    ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_recebimento_produto", oSqlParameter)

                    'Verifica se o Item Controla Estoque
                    If oRow.Cells("item_estoque").Value = True Then

                        Dim sLinha() As String
                        Dim sDados() As String
                        Dim j As Integer

                        sLinha = oRow.Cells("recebimento").Value.ToString.Split("|")

                        For j = 0 To UBound(sLinha)

                            sDados = sLinha(j).Split("§")

                            'Insere Registro de Estoque
                            Call InsertRecebimentoItemEstoque(lCodigoRecebimento, _
                                                              oSqlParameter(5).Value, _
                                                              sDados(3), _
                                                              sDados(2).Replace(".", ","), _
                                                              sDados(1))
                        Next

                    End If

                End If

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertRecebimentoItemEstoque(ByVal lCodigoRecebimento As Long, _
                                            ByVal iCodigoRecebimentoItem As Integer, _
                                            ByVal iCodigoDeposito As Integer, _
                                            ByVal dQuantidade As Double, _
                                            ByVal sLote As String)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recebimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recebimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRecebimento : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Recebimento Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recebimento_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoRecebimentoItem : i += 1

            'Seta Parametros - Código Depósito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoDeposito : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sLote = "", DBNull.Value, sLote)

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_recebimento_item_estoque", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridItem(ByVal oGrid As GridEX, _
                            ByVal sCodigoPedido As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sCodigoPedido : i += 1

            'Seta Parametros - Código de Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_recebimento_item", oSqlParameter)

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

#End Region

#Region "::: FATURA :::"

    Public Sub GerarDuplicata(ByVal oGrid As GridEX, _
                              ByVal dDataEmissao As Date, _
                              ByVal dValor As Double, _
                              ByVal iNumeroParcela As Integer, _
                              ByVal iIntervaloParcela As Integer)

        Try

            'Limpa Grid
            oGrid.DataSource = Nothing

            'Caso Valor Liquido maior que 0
            If dValor > 0 Then

                'Variaveis Locais
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDCVencimento As New DataColumn("data_vencimento")
                Dim oDCValor As New DataColumn("valor")
                Dim dValorResidual As Double = dValor

                'Seta DataType
                oDCVencimento.DataType = Now.Date.GetType
                oDCValor.DataType = 0.0.GetType

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)

                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCVencimento)
                oDataTable.Columns.Add(oDCValor)

                'Adiciona Linhas ao DataTable
                For i = 1 To iNumeroParcela
                    Dim oDataRow As DataRow = oDataTable.NewRow
                    oDataRow("data_vencimento") = CDate(DateAdd(DateInterval.Day, i * iIntervaloParcela, dDataEmissao))
                    oDataRow("valor") = IIf(iNumeroParcela = i, dValorResidual, FormatNumber(dValor / iNumeroParcela, 2))
                    dValorResidual -= FormatNumber(dValor / iNumeroParcela, 2)
                    oDataTable.Rows.Add(oDataRow)
                Next

                'Configura DataMember
                Call ConfigurarDataMemberGrid(oGrid)

                'Carrega Grid
                oGrid.DataSource = oDataSet.DefaultViewManager
                oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertRecebimentoFatura(ByVal lCodigoRecebimento As Long, _
                                       ByVal sFatura As String, _
                                       ByVal dValorOriginal As Double, _
                                       ByVal dValorDesconto As Double, _
                                       ByVal dValorLiquido As Double, _
                                       ByVal iCodigoTipoDocumentoPagamento As Integer, _
                                       ByVal iNumeroParcela As Integer, _
                                       ByVal iIntervaloEntreParcelas As Integer)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Recebimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_recebimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRecebimento : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Fatura
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fatura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 60
            oSqlParameter(i).Value = sFatura : i += 1

            'Seta Parametros - Valor Original
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_original"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorOriginal : i += 1

            'Seta Parametros - Valor Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorDesconto : i += 1

            'Seta Parametros - Valor Líquido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_liquido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorLiquido : i += 1

            'Seta Parametros - Código Tipo Documento Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tipo_documento_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoTipoDocumentoPagamento : i += 1

            'Seta Parametros - Nº Parcelas
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iNumeroParcela : i += 1

            'Seta Parametros - Intervalo Parcelas
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "intervalo_parcela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iIntervaloEntreParcelas

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_recebimento_fatura", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertRecebimentoFaturaDuplicata(ByVal lCodigoRecebimento As Long, _
                                                ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In oGrid.GetDataRows

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Recebimento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_recebimento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoRecebimento : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Nº Duplicata
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "numero_duplicata"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.RowIndex + 1 : i += 1

                'Seta Parametros - Data Vencimento
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "data_vencimento"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.DateTime
                oSqlParameter(i).Value = oRow.Cells("data_vencimento").Value : i += 1

                'Seta Parametros - Valor
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "valor"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Float
                oSqlParameter(i).Value = oRow.Cells("valor").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_recebimento_fatura_duplicata", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#End Region

End Class
