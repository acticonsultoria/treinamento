Imports System.Data
Imports System.Data.SqlClient
Imports SysACTi.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrCmpRecebimento

#Region "::: VARIAVEIS :::"

    'Capa
    Private sNumeroDocumento As String
    Private sSerie As String
    Private iTipoDocumento As Integer
    Private iFornecedor As Integer
    Private dDataEmissao As Date
    Private dDataEntrada As Date
    Private dValorFrete As Double
    Private lCodigoRecebimentoCapa As Long

#End Region

#Region "::: PROPERTIE :::"

    Property NumeroDocumento() As String
        Get
            Return sNumeroDocumento
        End Get
        Set(ByVal value As String)
            sNumeroDocumento = value
        End Set
    End Property

    Property Serie() As String
        Get
            Return sSerie
        End Get
        Set(ByVal value As String)
            sSerie = value
        End Set
    End Property

    Property TipoDocumento() As Integer
        Get
            Return iTipoDocumento
        End Get
        Set(ByVal value As Integer)
            iTipoDocumento = value
        End Set
    End Property

    Property DataEmissao() As Date
        Get
            Return dDataEmissao
        End Get
        Set(ByVal value As Date)
            dDataEmissao = value
        End Set
    End Property

    Property DataEntrada() As Date
        Get
            Return dDataEntrada
        End Get
        Set(ByVal value As Date)
            dDataEntrada = value
        End Set
    End Property

    Property CodigoRecebimentoCapa() As Long
        Get
            Return lCodigoRecebimentoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoRecebimentoCapa = value
        End Set
    End Property

    Property ValorFrete() As Double
        Get
            Return dValorFrete
        End Get
        Set(ByVal value As Double)
            dValorFrete = value
        End Set
    End Property

    Property Fornecedor() As Integer
        Get
            Return iFornecedor
        End Get
        Set(ByVal value As Integer)
            iFornecedor = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadGridPedidos(ByVal oGrid As GridEX, _
                               ByVal lCodigoPedido As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código do Pedido Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_fornecedor"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoPedido

            'Seta Parametros - Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_recebimento_pedido", oSqlParameter)

            With oGrid

                .RootTable.Columns.Item("numero_pedido").DataMember = "numero_pedido"
                .RootTable.Columns.Item("codigo").DataMember = "codigo"

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridRecebimentoMaterial(ByVal oGrid As GridEX, _
                                           ByRef oCheckedRows() As GridEXRow)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oRow As Janus.Windows.GridEX.GridEXRow
        Dim oSqlParameter(1) As SqlParameter
        Dim sParametros As String = ""

        Try

            For Each oRow In oCheckedRows
                sParametros = sParametros & IIf(sParametros = "", "", ", ") & oRow.Cells.Item("codigo").Value
            Next

            sParametros = "(" & IIf(sParametros = "", "0", sParametros) & ")"

            'Seta Parametros - Codigos do Pedidos
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_pedido_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 500
            oSqlParameter(0).Value = sParametros

            'Seta Parametros - Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_recebimento_material", oSqlParameter)

            With oGrid

                .RootTable.Columns.Item("numero_pedido").DataMember = "numero_pedido"
                .RootTable.Columns.Item("numero_requisicao").DataMember = "numero_requisicao"
                .RootTable.Columns.Item("item").DataMember = "item"
                .RootTable.Columns.Item("part_number").DataMember = "part_number"
                .RootTable.Columns.Item("quantidade_pedido").DataMember = "quantidade_pedido"
                .RootTable.Columns.Item("quantidade_pendente").DataMember = "quantidade_pendente"
                .RootTable.Columns.Item("quantidade_entregue").DataMember = "quantidade_entregue"
                .RootTable.Columns.Item("valor_unitario").DataMember = "valor_unitario"
                .RootTable.Columns.Item("valor_total").DataMember = "valor_total"
                .RootTable.Columns.Item("requisitante").DataMember = "requisitante"
                .RootTable.Columns.Item("codigo_pedido_linha").DataMember = "codigo_pedido_linha"
                .RootTable.Columns.Item("codigo_pedido_capa").DataMember = "codigo_pedido_capa"

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridRecebimentoServico(ByVal oGrid As GridEX, _
                                          ByRef oCheckedRows() As GridEXRow)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim iCont As Integer
        Dim oRow As Janus.Windows.GridEX.GridEXRow
        Dim oSqlParameter(1) As SqlParameter
        Dim sParametros As String = "("

        Try

            If oCheckedRows.Count > 0 Then
                iCont = 0
                For Each oRow In oCheckedRows
                    sParametros = sParametros & oRow.Cells.Item("codigo").Value & ","
                    iCont += 1
                Next
                sParametros = Mid(sParametros, 1, Len(sParametros) - 1)
                sParametros = sParametros + ")"
            Else
                sParametros = sParametros + "0)"
            End If

            'Seta Parametros - Codigos do Pedidos
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_pedido_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 500
            oSqlParameter(0).Value = sParametros

            'Seta Parametros - Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_recebimento_servico", oSqlParameter)

            With oGrid

                .RootTable.Columns.Item("numero_pedido").DataMember = "numero_pedido"
                .RootTable.Columns.Item("numero_requisicao").DataMember = "numero_requisicao"
                .RootTable.Columns.Item("servico").DataMember = "servico"
                .RootTable.Columns.Item("valor_pedido").DataMember = "valor_pedido"
                .RootTable.Columns.Item("valor_pago").DataMember = "valor_pago"
                .RootTable.Columns.Item("valor_nota_fiscal").DataMember = "valor_nota_fiscal"
                .RootTable.Columns.Item("valor_pendente").DataMember = "valor_pendente"
                .RootTable.Columns.Item("codigo_pedido_linha").DataMember = "codigo_pedido_linha"
                .RootTable.Columns.Item("codigo_pedido_capa").DataMember = "codigo_pedido_capa"
                .RootTable.Columns.Item("quantidade").DataMember = "quantidade"

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    Public Sub InsertFaturamentoCapa()

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter

        Try

            'Seta Parametros - Código Fornecedor
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_fornecedor"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iFornecedor

            'Seta Parametros - Numero Documento
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "numero_documento"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 20
            oSqlParameter(1).Value = sNumeroDocumento

            'Seta Parametros - Série
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "serie"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Size = 5
            oSqlParameter(2).Value = sSerie

            'Seta Parametros - Tipo de Documento
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_tipo_documento"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iTipoDocumento

            'Seta Parametros - Data de Emissão
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "data_emissao"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Date
            oSqlParameter(4).Value = dDataEmissao

            'Seta Parametros - Data de Entrada
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "data_entrada"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Date
            oSqlParameter(5).Value = dDataEntrada

            'Seta Parametros - Valor Frete
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "valor_frete"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Float
            oSqlParameter(6).Value = dValorFrete

            'Seta Parametros - Código Usuário
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "codigo_usuario"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.Int
            oSqlParameter(7).Value = goUsuario.iUsuario

            'Seta Parametros - Empresa
            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "codigo_empresa"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.Int
            oSqlParameter(8).Value = goUsuario.iEmpresa

            'OutPut - Código Despesa
            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "codigo"
            oSqlParameter(9).Direction = ParameterDirection.Output
            oSqlParameter(9).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_recebimento_capa", oSqlParameter)

            'Seta Retorno da Função
            lCodigoRecebimentoCapa = oSqlParameter(9).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertFaturamentoLinha(ByVal oRow As GridEXRow)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            With oRow.Cells

                'Seta Parametros - Código da Recebimento Capa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_recebimento_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoRecebimentoCapa

                'Seta Parametros - Código do Pedido Linha
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_pedido_linha"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.BigInt
                oSqlParameter(1).Value = .Item("codigo_pedido_linha").Value

                'Seta Parametros - Quantidade
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "quantidade"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.Float
                oSqlParameter(2).Value = .Item("quantidade_entregue").Value


                'Seta Parametros - Valor Unitário
                oSqlParameter(3) = New SqlParameter
                oSqlParameter(3).ParameterName = "valor_unitario"
                oSqlParameter(3).Direction = ParameterDirection.Input
                oSqlParameter(3).SqlDbType = SqlDbType.Float
                oSqlParameter(3).Value = .Item("valor_unitario").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_recebimento_linha", oSqlParameter)

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertFaturamentoEntradaCapa()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter

        Try

            'Input - Código recebimento capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_recebimento_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoRecebimentoCapa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_recebimento_faturamento_entrada", oSqlParameter)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub InsertRecebimentoCapa()

        'Variaveis Locais
        Dim oSqlParameter(9) As SqlParameter

        Try

            'Seta Parametros - Código Fornecedor
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_fornecedor"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iFornecedor

            'Seta Parametros - Numero Documento
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "numero_documento"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 20
            oSqlParameter(1).Value = sNumeroDocumento

            'Seta Parametros - Série
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "serie"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.VarChar
            oSqlParameter(2).Size = 5
            oSqlParameter(2).Value = sSerie

            'Seta Parametros - Tipo de Documento
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_tipo_documento"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = iTipoDocumento

            'Seta Parametros - Data de Emissão
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "data_emissao"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Date
            oSqlParameter(4).Value = dDataEmissao

            'Seta Parametros - Data de Entrada
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "data_entrada"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Date
            oSqlParameter(5).Value = dDataEntrada

            'Seta Parametros - Valor Frete
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "valor_frete"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Float
            oSqlParameter(6).Value = dValorFrete

            'Seta Parametros - Código Usuário
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "codigo_usuario"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.Int
            oSqlParameter(7).Value = goUsuario.iUsuario

            'Seta Parametros - Empresa
            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "codigo_empresa"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.Int
            oSqlParameter(8).Value = goUsuario.iEmpresa

            'OutPut - Código Despesa
            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "codigo"
            oSqlParameter(9).Direction = ParameterDirection.Output
            oSqlParameter(9).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_recebimento_capa", oSqlParameter)

            'Seta Retorno da Função
            lCodigoRecebimentoCapa = oSqlParameter(9).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertRecebimentoLinha(ByVal oRow As GridEXRow)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            With oRow.Cells

                'Seta Parametros - Código da Recebimento Capa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_recebimento_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoRecebimentoCapa

                'Seta Parametros - Código do Pedido Linha
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_pedido_linha"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.BigInt
                oSqlParameter(1).Value = .Item("codigo_pedido_linha").Value

                'Seta Parametros - Quantidade
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "quantidade"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.Float
                oSqlParameter(2).Value = .Item("quantidade_entregue").Value


                'Seta Parametros - Valor Unitário
                oSqlParameter(3) = New SqlParameter
                oSqlParameter(3).ParameterName = "valor_unitario"
                oSqlParameter(3).Direction = ParameterDirection.Input
                oSqlParameter(3).SqlDbType = SqlDbType.Float
                oSqlParameter(3).Value = .Item("valor_unitario").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_recebimento_linha", oSqlParameter)

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertRecebimentoLinhaServico(ByVal oRow As GridEXRow)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            With oRow.Cells

                'Seta Parametros - Código da Recebimento Capa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_recebimento_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoRecebimentoCapa

                'Seta Parametros - Código do Pedido Linha
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_pedido_linha"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.BigInt
                oSqlParameter(1).Value = .Item("codigo_pedido_linha").Value

                'Seta Parametros - Quantidade
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "quantidade"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.Float
                oSqlParameter(2).Value = FormatNumber(((.Item("valor_nota_fiscal").Value) / (.Item("valor_pedido").Value)) * (.Item("quantidade").Value), 2)


                'Seta Parametros - Valor Unitário
                oSqlParameter(3) = New SqlParameter
                oSqlParameter(3).ParameterName = "valor_unitario"
                oSqlParameter(3).Direction = ParameterDirection.Input
                oSqlParameter(3).SqlDbType = SqlDbType.Float
                oSqlParameter(3).Value = .Item("valor_nota_fiscal").Value / FormatNumber(((.Item("valor_nota_fiscal").Value) / (.Item("valor_pedido").Value)) * (.Item("quantidade").Value), 2)

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_recebimento_linha", oSqlParameter)

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaNumeroDocumento() As Boolean

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim iReturn As Integer

        Try

            'Seta Parametros - Numero Documento
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "numero_documento"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 20
            oSqlParameter(0).Value = sNumeroDocumento

            'Seta Parametros - Série
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "serie"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 5
            oSqlParameter(1).Value = sSerie

            'Seta Parametros - Código Fornecedor
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_fornecedor"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iFornecedor

            'Seta Parametros - Empresa
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_empresa"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Int
            oSqlParameter(3).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_compras_recebimento", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaNumeroDocumento = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class

