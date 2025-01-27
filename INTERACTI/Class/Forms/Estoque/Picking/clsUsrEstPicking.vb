Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrEstPicking

#Region "::: VÁRIAVEIS :::"

    Private lCodigoPicking As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoPicking() As Long
        Get
            Return lCodigoPicking
        End Get
        Set(ByVal value As Long)
            lCodigoPicking = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: LISTAGEM :::"

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal sNumeroPicking As String, _
                        ByVal sDataInicio As String, _
                        ByVal sDataTermino As String, _
                        ByVal sNumeroPedidoVenda As String, _
                        ByVal sNumeroPedidoVendaCliente As String, _
                        ByVal sReferencia As String, _
                        ByVal sCliente As String, _
                        ByVal sCodigoGrupoItem As String, _
                        ByVal sProduto As String, _
                        ByVal iStatus As Integer)

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Nº Picking
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_picking"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroPicking : i += 1

            'Seta Parametros - Data Pedido Início
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataInicio), sDataInicio, DBNull.Value) : i += 1

            'Seta Parametros - Data Pedido Término
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = IIf(IsDate(sDataTermino), sDataTermino, DBNull.Value) : i += 1

            'Seta Parametros - Nº Pedido Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroPedidoVenda : i += 1

            'Seta Parametros - Nº Pedido Venda - Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroPedidoVendaCliente : i += 1

            'Seta Parametros - Referência
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "referencia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 500
            oSqlParameter(i).Value = sReferencia : i += 1

            'Seta Parametros - Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sCliente : i += 1

            'Seta Parametros - Código Grupo de Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_grupo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 100
            oSqlParameter(i).Value = sCodigoGrupoItem : i += 1

            'Seta Parametros - Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sProduto : i += 1

            'Seta Parametros - Status
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iStatus

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_estoque_picking", oSqlParameter)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo_picking"), oDataSet.Tables(1).Columns("codigo_picking"))

            'Carrega grid
            Call ConfigurarDataMemberGrid(oGrid)
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_pedido"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_pedido").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_estoque_picking", oSqlParameter)

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

#Region "::: PEDIDO VENDA :::"

    Public Sub LoadGridPedidoVenda(ByVal oGrid As GridEX, _
                                   ByVal lCodigoPedido As Long, _
                                   ByVal lCodigoPicking As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            'Seta Parametros - Código Picking
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_picking"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPicking

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_estoque_picking_pedido_venda", oSqlParameter)

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

    Public Sub LoadDadosPedidoVenda(ByVal lCodigoPedido As Long, _
                                    ByVal txtDataPedido As MaskedEditBox, _
                                    ByVal txtCliente As MaskedEditBox, _
                                    ByVal txtNumeroPedidoCliente As MaskedEditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_pedido_dados", oSqlParameter)

            While oSqlDataReader.Read

                'Carrega Controles
                txtDataPedido.Text = oSqlDataReader.Item("data_pedido")
                txtCliente.Text = oSqlDataReader.Item("cliente")
                txtNumeroPedidoCliente.Text = oSqlDataReader.Item("numero_pedido_cliente")

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

#Region "::: PICKING :::"

    Public Sub Cancelar(ByVal sHistorico As String)

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Picking
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_picking"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_picking").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Histórico
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "historico"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.VarChar
                oSqlParameter(i).Size = 500
                oSqlParameter(i).Value = sHistorico : i += 1

                'Seta Parametros - Codigo Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                'Seta Parametros - Status
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "status"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = StatusPicking.Cancelado

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_estoque_picking_status", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadQuantidadeEstoque(ByVal lCodigoItem As Long, _
                                     ByVal iCodigoDeposito As Integer, _
                                     ByVal sLote As String, _
                                     ByRef dQuantidade As Double)

        Try

            'Váriaveis Locais
            Dim oSqlParameter(3) As SqlParameter
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
            dQuantidade = ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_estoque_quantidade_item_deposito_lote", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertPicking(ByVal lCodigoPedido As Long, _
                             ByVal sDataPicking As String, _
                             ByVal txtNumeroPedido As MaskedEditBox, _
                             Optional ByVal lCodigo As Long = 0)

        'Variaveis Locais        
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Número Picking
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_picking"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20 : i += 1

            'Seta Parametros - Código Picking
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.InputOutput
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Data Picking
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_picking"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sDataPicking : i += 1

            'Seta Parametros - Código Pedido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

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
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_estoque_picking", oSqlParameter)

            txtNumeroPedido.Text = oSqlParameter(0).Value
            lCodigoPicking = oSqlParameter(1).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertPickingProduto(ByVal oGrid As GridEX)

        'Variaveis Locais        
        Dim oSqlParameter(6) As SqlParameter
        Dim sEntrega() As String
        Dim sDadoEntrega() As String
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In oGrid.GetDataRows

                If oRow.Cells("picking").Value <> "" Then

                    'Seta Váriavel
                    i = 0

                    'Seta Parametros - Código Picking
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_picking"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(i).Value = lCodigoPicking : i += 1

                    'Seta Parametros - Código Empresa
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_empresa"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

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
                    oSqlParameter(i).Value = oRow.Cells("quantidade_picking_elaboracao").Value : i += 1

                    'Seta Parametros - Código
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo"
                    oSqlParameter(i).Direction = ParameterDirection.Output
                    oSqlParameter(i).SqlDbType = SqlDbType.Int

                    'Executa Query
                    ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_estoque_picking_produto", oSqlParameter)

                    'Carrega Vetor - Entrega
                    sEntrega = oRow.Cells("picking").Value.ToString.Split("|")

                    For j As Integer = 0 To UBound(sEntrega)

                        'Carrega Vetor
                        sDadoEntrega = sEntrega(j).Split("§")

                        'Insere Registro na tb_est_picking_entrega
                        Call InsertPickingProdutoEntrega(oSqlParameter(i).Value, _
                                                         sDadoEntrega(3), _
                                                         sDadoEntrega(1), _
                                                         sDadoEntrega(2))

                    Next

                End If

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeletePickingProduto(ByVal oGrid As GridEX)

        'Variaveis Locais        
        Dim oSqlParameter(6) As SqlParameter
        Dim sEntrega() As String
        Dim sDadoEntrega() As String
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In oGrid.GetDataRows

                If oRow.Cells("picking").Value <> "" Then

                    'Seta Váriavel
                    i = 0

                    'Seta Parametros - Código Picking
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_picking"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                    oSqlParameter(i).Value = lCodigoPicking : i += 1

                    'Seta Parametros - Código Empresa
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo_empresa"
                    oSqlParameter(i).Direction = ParameterDirection.Input
                    oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                    oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

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
                    oSqlParameter(i).Value = oRow.Cells("quantidade_picking_elaboracao").Value : i += 1

                    'Seta Parametros - Código
                    oSqlParameter(i) = New SqlParameter
                    oSqlParameter(i).ParameterName = "codigo"
                    oSqlParameter(i).Direction = ParameterDirection.Output
                    oSqlParameter(i).SqlDbType = SqlDbType.Int

                    'Executa Query
                    ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_estoque_picking_produto", oSqlParameter)

                    'Carrega Vetor - Entrega
                    sEntrega = oRow.Cells("picking").Value.ToString.Split("|")

                    For j As Integer = 0 To UBound(sEntrega)

                        'Carrega Vetor
                        sDadoEntrega = sEntrega(j).Split("§")

                        'Insere Registro na tb_est_picking_entrega
                        Call InsertPickingProdutoEntrega(oSqlParameter(i).Value, _
                                                         sDadoEntrega(3), _
                                                         sDadoEntrega(1), _
                                                         sDadoEntrega(2))

                    Next

                End If

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeletePickingProdutoEntrega()

        'Variaveis Locais        
        Dim oSqlParameter(6) As SqlParameter
        Dim sEntrega() As String
        Dim sDadoEntrega() As String
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Picking
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_picking"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo_picking").Value : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código Picking Produto
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_picking_produto"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo_picking_produto").Value : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Executa Query
                'ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_estoque_picking_produto_entrega", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertPickingProdutoEntrega(ByVal iCodigoPickingProduto As Integer, _
                                           ByVal iCodigoDeposito As Integer, _
                                           ByVal sLote As String, _
                                           ByVal dQuantidade As Double)

        'Variaveis Locais        
        Dim oSqlParameter(5) As SqlParameter
        Dim i As Integer

        Try

            'Seta Parametros - Código Picking
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_picking"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPicking : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Picking Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_picking_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPickingProduto : i += 1

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
            oSqlParameter(i).Value = IIf(sLote = "", DBNull.Value, sLote) : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_estoque_picking_produto_entrega", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridHistorico(ByVal oGrid As GridEX, _
                                 ByVal lCodigoPicking As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Picking
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_picking"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPicking

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_estoque_picking_historico", oSqlParameter)

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

    Public Sub LoadGridPicking(ByVal oGrid As GridEX, _
                               ByVal lCodigoPicking As Long, _
                               ByVal iCodigoPickingProduto As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim oDataSet As DataSet
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código Picking
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_picking"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPicking : i += 1

            'Seta Parametros - Código Picking Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_picking_produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPickingProduto

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_estoque_picking_produto", oSqlParameter)

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

    Public Function ValidaEstoque(ByVal lCodigoItem As Long, _
                                  ByVal iCodigoDeposito As Integer, _
                                  ByVal sLote As String, _
                                  ByVal dQuantidade As Double) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim bReturn As Boolean
        Dim i As Integer = 0

        Try

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
            oSqlParameter(i).Value = sLote : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade

            'Executa Query
            bReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_estoque_picking_produto", oSqlParameter), Boolean)

            'Retorno da Função
            Return bReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

#End Region

End Class
