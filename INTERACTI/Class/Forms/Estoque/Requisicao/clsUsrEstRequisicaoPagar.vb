Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrEstRequisicaoPagar

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX,
                        ByVal lNumeroRequisicao As Long,
                        ByVal sDataRequisicaoInicio As String,
                        ByVal sDataRequisicaoTermino As String,
                        ByVal sNumeroDocumento As String,
                        ByVal sItem As String,
                        ByVal sDataNecessidadeInicio As String,
                        ByVal sDataNecessidadeTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Número Requisição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_requisicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNumeroRequisicao : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Inicio da Requisição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_requisicao_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataRequisicaoInicio = "", DBNull.Value, sDataRequisicaoInicio) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Término da Requisição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_requisicao_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataRequisicaoTermino = "", DBNull.Value, sDataRequisicaoTermino) : i += 1 : ReDim Preserve oSqlParameter(i)


            'Seta Parametros - Nº Documento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_documento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroDocumento : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sItem : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Necessidade Inicio
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_necessidade_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataNecessidadeInicio = "", DBNull.Value, sDataNecessidadeInicio) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Data Necessidade Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_necessidade_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(sDataNecessidadeTermino = "", DBNull.Value, sDataNecessidadeTermino) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_estoque_requisicao_pagar", oSqlParameter)

            Dim oParentColumn(1) As DataColumn
            Dim oChildColumn1(1) As DataColumn

            oParentColumn(0) = oDataSet.Tables(0).Columns("codigo_requisicao")
            oParentColumn(1) = oDataSet.Tables(0).Columns("codigo")

            oChildColumn1(0) = oDataSet.Tables(1).Columns("codigo_requisicao")
            oChildColumn1(1) = oDataSet.Tables(1).Columns("codigo_requisicao_item")

            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oParentColumn, oChildColumn1)

            'Configura DataMember
            ConfigurarDataMemberGrid(oGrid)

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

    Public Sub PagarRequisicao(ByVal lCodigoRequisicao As Long, _
                               ByVal iCodigoRequisicaoItem As Integer, _
                               ByVal dQuantidade As Double, _
                               ByVal sLote As String, _
                               ByVal iCodigoDeposito As Integer, _
                               ByVal dFator As Double, _
                               ByVal lCodigoItemAlternativo As Long, _
                               ByVal iCodigoFuncionario As Integer, _
                               ByVal lCodigoPedido As Long, _
                               ByVal iCodigoPedidoItem As Integer, _
                               ByVal iCodigoPedidoItemEntrega As Integer)

        'Variaveis Locais        
        Dim oSqlParameter(0) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Requisição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_requisicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRequisicao : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoRequisicaoItem : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Quantidade Paga
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade_paga"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sLote = "", DBNull.Value, sLote) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Depósito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoDeposito : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Fator
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fator"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = IIf(lCodigoItemAlternativo = -1, 1, dFator) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Item Alternativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_alternativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoItemAlternativo = -1, DBNull.Value, lCodigoItemAlternativo) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Funcionário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_funcionario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(iCodigoFuncionario = -1, DBNull.Value, iCodigoFuncionario) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoPedido = -1, DBNull.Value, lCodigoPedido) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoPedidoItem = -1, DBNull.Value, iCodigoPedidoItem) : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoPedidoItemEntrega = -1, DBNull.Value, iCodigoPedidoItemEntrega) : i += 1 : ReDim Preserve oSqlParameter(i)

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_estoque_requisicao_pagar_item", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub FecharRequisicao(ByVal lCodigoRequisicao As Long, _
                                ByVal iCodigoRequisicaoItem As Integer)

        'Variaveis Locais        
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Requisição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_requisicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRequisicao : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoRequisicaoItem : i += 1

            'Seta Parametros - Código Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_estoque_requisicao_fechar_item", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub CancelarRequisicao()

        'Variaveis Locais        
        Dim oSqlParameter(3) As SqlParameter
        Dim j, i As Integer

        Try

            For j = 0 To UBound(gSelecaoRow)

                i = 0

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Requisição
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_requisicao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = gSelecaoRow(j).Cells("codigo_requisicao").Value : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = gSelecaoRow(j).Cells("codigo").Value : i += 1

                'Seta Parametros - Status
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "status"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = StatusRequisicaoEstoque.Cancelada

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_estoque_cancelar_requisicao_item", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaItemNTO(ByVal lCodigoPedido As Long, _
                                  ByVal iCodigoPedidoItem As Integer, _
                                  ByVal iCodigoPedidoItemEntrega As Integer) As Boolean

        Try

            'Váriaveis Locais
            Dim oSqlParameter(3) As SqlParameter
            Dim iReturn As Integer
            Dim i As Integer = 0

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código Depósito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPedidoItem : i += 1

            'Seta Parametros - Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPedidoItemEntrega

            'Executa Query
            iReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_estoque_requisicao_pagar_nto", oSqlParameter)

            'Retorno da Função
            Return IIf(iReturn > 0, True, False)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaItemInspecao(ByVal lCodigoPedido As Long, _
                                  ByVal iCodigoPedidoItem As Integer, _
                                  ByVal iCodigoPedidoItemEntrega As Integer) As Boolean

        Try

            'Váriaveis Locais
            Dim oSqlParameter(3) As SqlParameter
            Dim iReturn As Integer
            Dim i As Integer = 0

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código Depósito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPedidoItem : i += 1

            'Seta Parametros - Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPedidoItemEntrega

            'Executa Query
            iReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_estoque_requisicao_pagar_inspecao", oSqlParameter)

            'Retorno da Função
            Return IIf(iReturn > 0, True, False)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaProduto(ByVal lCodigoItem As Long, _
                                  ByVal iCodigoDeposito As Integer, _
                                  ByVal sLote As String) As Double

        Try

            'Váriaveis Locais
            Dim oSqlParameter(3) As SqlParameter
            Dim dReturn As Double
            Dim i As Integer = 0

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Código Depósito
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_deposito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoDeposito : i += 1

            'Seta Parametros - Lote
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "lote"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 50
            oSqlParameter(i).Value = IIf(sLote = "", DBNull.Value, sLote)

            'Executa Query
            dReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_estoque_requisicao_pagar", oSqlParameter)

            'Retorno da Função
            Return dReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function ValidaAprovacaoRequisicao(ByVal iCodigoRequisicao As Integer
                                              ) As Boolean

        Try

            'Váriaveis Locais
            Dim i As Integer = 0
            Dim oSqlParameter(i) As SqlParameter
            Dim iReturn As Integer

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1 : ReDim Preserve oSqlParameter(i)

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_requisicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigoRequisicao : i += 1

            'Executa Query
            iReturn = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_estoque_requisicao_pagamento_aprovacao", oSqlParameter)

            'Retorno da Função
            Return IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub LoadDadosRequisicaoProdutoAlternativo(ByVal lCodigoRequisicao As Long, _
                                                     ByVal iCodigoRequisicaoItem As Integer, _
                                                     ByVal lCodigoItemOriginal As Long, _
                                                     ByVal lCodigoItemAlternativo As Long, _
                                                     ByRef bControlaLote As Double, _
                                                     ByRef dFator As Double)

        Try

            'Váriaveis Locais
            Dim oSqlParameter(4) As SqlParameter
            Dim oSqlDataReader As SqlDataReader
            Dim i As Integer = 0

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Requisição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_requisicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRequisicao : i += 1

            'Seta Parametros - Código Requisição Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_requisicao_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoRequisicaoItem : i += 1

            'Seta Parametros - Código Item Original
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_original"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItemOriginal : i += 1

            'Seta Parametros - Código Item Alternativo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item_alternativo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItemAlternativo

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_estoque_requisicao_pagar_produto_alternativo", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                dFator = oSqlDataReader.Item("fator")
                bControlaLote = oSqlDataReader.Item("controla_lote")

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