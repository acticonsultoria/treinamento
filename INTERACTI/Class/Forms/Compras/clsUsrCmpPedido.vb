Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls

Public Class clsUsrCmpPedido

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sNumeroPedido As String
    Private sData As String
    Private lFornecedor As Long
    Private iTipoPedido As Integer
    Private iFormaPagamento As Integer
    Private iNumeroParcela As Integer
    Private dDescontoPercentual As Double
    Private dDescontoValor As Double
    Private iIntervaloParcela As Integer
    Private sObservacao As String
    Private lCodigoPedidoCapa As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property NumeroPedido() As String
        Get
            Return sNumeroPedido
        End Get
        Set(ByVal value As String)
            sNumeroPedido = value
        End Set
    End Property

    Public Property Data() As String
        Get
            Return sData
        End Get
        Set(ByVal value As String)
            sData = value
        End Set
    End Property

    Public Property Fornecedor() As Long
        Get
            Return lFornecedor
        End Get
        Set(ByVal value As Long)
            lFornecedor = value
        End Set
    End Property

    Public Property TipoPedido() As Integer
        Get
            Return iTipoPedido
        End Get
        Set(ByVal value As Integer)
            iTipoPedido = value
        End Set
    End Property

    Public Property FormaPagamento() As Integer
        Get
            Return iFormaPagamento
        End Get
        Set(ByVal value As Integer)
            iFormaPagamento = value
        End Set
    End Property

    Public Property DescontoPercentual() As Double
        Get
            Return dDescontoPercentual
        End Get
        Set(ByVal value As Double)
            dDescontoPercentual = value
        End Set
    End Property

    Public Property DescontoValor() As Double
        Get
            Return dDescontoValor
        End Get
        Set(ByVal value As Double)
            dDescontoValor = value
        End Set
    End Property

    Public Property NumeroParcela() As Integer
        Get
            Return iNumeroParcela
        End Get
        Set(ByVal value As Integer)
            iNumeroParcela = value
        End Set
    End Property

    Public Property IntervaloParcela() As Integer
        Get
            Return iIntervaloParcela
        End Get
        Set(ByVal value As Integer)
            iIntervaloParcela = value
        End Set
    End Property

    Public Property Observacao() As String
        Get
            Return sObservacao
        End Get
        Set(ByVal value As String)
            sObservacao = value
        End Set
    End Property

    Public Property CodigoPedidoCapa() As Long
        Get
            Return lCodigoPedidoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoPedidoCapa = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Delete()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer

        Try

            For i = 0 To UBound(gSelecaoRow)

                'Seta Parametros - Código
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = gSelecaoRow(i).Cells("codigo").Value

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_compra_pedido_capa", oSqlParameter)

                'Deleta Linha
                gSelecaoRow(i).Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(12) As SqlParameter

        Try

            'Seta Parametros - Número do Pedido
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "numero_pedido"
            oSqlParameter(0).Direction = ParameterDirection.Output
            oSqlParameter(0).SqlDbType = SqlDbType.VarChar
            oSqlParameter(0).Size = 20

            'Seta Parametros - Data
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "data_pedido"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Date
            oSqlParameter(1).Value = sData

            'Seta Parametros - Fornecedor
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_fornecedor"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.BigInt
            oSqlParameter(2).Value = lFornecedor

            'Seta Parametros - Tipo de Pedido
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_tipo_pedido"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(3).Value = iTipoPedido

            'Seta Parametros - Forma de Pagamento
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_forma_pagamento_nfe"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(4).Value = iFormaPagamento

            'Seta Parametros - Desconto %
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "desconto_percentual"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Float
            oSqlParameter(5).Value = dDescontoPercentual

            'Seta Parametros - Desconto Valor
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "desconto_valor"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Float
            oSqlParameter(6).Value = dDescontoValor

            'Seta Parametros - Número de Parcelas
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "numero_parcela"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(7).Value = iNumeroParcela

            'Seta Parametros - Intervalo Parcela
            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "intervalo_parcela"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(8).Value = iIntervaloParcela

            'Seta Parametros - Observacao
            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "observacao"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.Text
            oSqlParameter(9).Value = IIf(sObservacao = "", DBNull.Value, sObservacao)

            'Seta Parametros - Código Empresa
            oSqlParameter(10) = New SqlParameter
            oSqlParameter(10).ParameterName = "codigo_empresa"
            oSqlParameter(10).Direction = ParameterDirection.Input
            oSqlParameter(10).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(10).Value = goUsuario.iEmpresa

            'Seta Parametros - Código Usuário
            oSqlParameter(11) = New SqlParameter
            oSqlParameter(11).ParameterName = "codigo_usuario"
            oSqlParameter(11).Direction = ParameterDirection.Input
            oSqlParameter(11).SqlDbType = SqlDbType.Int
            oSqlParameter(11).Value = goUsuario.iUsuario

            'Seta Parametros - Código
            oSqlParameter(12) = New SqlParameter
            oSqlParameter(12).ParameterName = "codigo"
            oSqlParameter(12).Direction = ParameterDirection.Output
            oSqlParameter(12).SqlDbType = SqlDbType.BigInt
            oSqlParameter(12).Value = lCodigoPedidoCapa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compra_pedido_capa", oSqlParameter)

            'Seta Váriaveis
            sNumeroPedido = oSqlParameter(0).Value
            lCodigoPedidoCapa = oSqlParameter(12).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Duplicar(ByVal lCodigo As Long)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            'Seta Parametros - Código Pedido Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_pedido_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigo

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Seta Parametros - Código Usuário
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_usuario"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = goUsuario.iUsuario

            'Seta Parametros - Código
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo"
            oSqlParameter(3).Direction = ParameterDirection.Output
            oSqlParameter(3).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compra_pedido_duplicar", oSqlParameter)

            'Seta Código
            lCodigoPedidoCapa = oSqlParameter(3).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter

        Try

            'Seta Parametros - Data
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "data_pedido"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Date
            oSqlParameter(0).Value = sData

            'Seta Parametros - Fornecedor
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_fornecedor"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = lFornecedor

            'Seta Parametros - Tipo de Pedido
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_tipo_pedido"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(2).Value = iTipoPedido

            'Seta Parametros - Forma de Pagamento
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_forma_pagamento_nfe"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(3).Value = iFormaPagamento

            'Seta Parametros - Desconto %
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "desconto_percentual"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Float
            oSqlParameter(4).Value = dDescontoPercentual

            'Seta Parametros - Desconto Valor
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "desconto_valor"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Float
            oSqlParameter(5).Value = dDescontoValor

            'Seta Parametros - Número de Parcelas
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "numero_parcela"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(6).Value = iNumeroParcela

            'Seta Parametros - Intervalo Parcela
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "intervalo_parcela"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(7).Value = iIntervaloParcela

            'Seta Parametros - Observacao
            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "observacao"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.Text
            oSqlParameter(8).Value = IIf(sObservacao = "", DBNull.Value, sObservacao)

            'Seta Parametros - Código
            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "codigo"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.BigInt
            oSqlParameter(9).Value = lCodigoPedidoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(10) = New SqlParameter
            oSqlParameter(10).ParameterName = "codigo_empresa"
            oSqlParameter(10).Direction = ParameterDirection.Input
            oSqlParameter(10).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(10).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compra_pedido_capa", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadControlesPedido(ByVal lCodigo As Long, _
                                   ByVal txtNumeroPedido As EditBox, _
                                   ByVal dtpDataPedido As DateTimePicker, _
                                   ByVal cboFornecedor As UIComboBox, _
                                   ByVal cboTipoPedido As UIComboBox, _
                                   ByVal cboFormaPagamento As UIComboBox, _
                                   ByVal txtDescontoTotalPercentual As NumericEditBox, _
                                   ByVal txtDescontoTotalValor As NumericEditBox, _
                                   ByVal txtNumeroParcela As NumericEditBox, _
                                   ByVal txtIntervaloParcela As NumericEditBox, _
                                   ByVal txtObservacao As EditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigo

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compra_pedido_dados_capa", oSqlParameter)

            'Verifica se encontrou algum Registro
            If oSqlDataReader.HasRows Then

                'Seta Controles
                While oSqlDataReader.Read

                    txtNumeroPedido.Text = oSqlDataReader.Item("numero_pedido")
                    txtNumeroPedido.Tag = lCodigo
                    dtpDataPedido.Value = oSqlDataReader.Item("data_pedido")
                    cboFornecedor.SelectedValue = oSqlDataReader.Item("codigo_fornecedor")
                    cboTipoPedido.SelectedValue = oSqlDataReader.Item("codigo_tipo_pedido")
                    cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento_nfe")
                    txtDescontoTotalPercentual.Value = oSqlDataReader.Item("desconto_percentual")
                    txtDescontoTotalValor.Value = oSqlDataReader.Item("desconto_valor")
                    txtNumeroParcela.Value = oSqlDataReader.Item("numero_parcela")
                    txtIntervaloParcela.Value = oSqlDataReader.Item("intervalo_parcela")
                    txtObservacao.Text = oSqlDataReader.Item("observacao")

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

    Public Sub LoadGridPedido(ByVal oGrid As GridEX, _
                              ByVal lNumeroPedido As Long, _
                              ByVal sDataInicio As String, _
                              ByVal sDataTermino As String, _
                              ByVal sFornecedor As String, _
                              ByVal iTipoPedido As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(5) As SqlParameter

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros - Número Pedido
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "numero_pedido"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = lNumeroPedido

            'Seta Parametros - Data Início
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "data_inicio"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Date
            oSqlParameter(2).Value = IIf(sDataInicio = "", DBNull.Value, sDataInicio)

            'Seta Parametros - Data Término
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "data_termino"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Date
            oSqlParameter(3).Value = IIf(sDataTermino = "", DBNull.Value, sDataTermino)

            'Seta Parametros - Fornecedor
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "fornecedor"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.VarChar
            oSqlParameter(4).Size = 120
            oSqlParameter(4).Value = sFornecedor

            'Seta Parametros - Tipo de Pedido
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "codigo_tipo_pedido"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(5).Value = iTipoPedido

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compra_pedido", oSqlParameter)

            With oGrid

                .RootTable.Columns.Item("numero_pedido").DataMember = "numero_pedido"
                .RootTable.Columns.Item("data_pedido").DataMember = "data_pedido"
                .RootTable.Columns.Item("fornecedor").DataMember = "fornecedor"
                .RootTable.Columns.Item("valor_total").DataMember = "valor_total"
                .RootTable.Columns.Item("desconto").DataMember = "desconto"
                .RootTable.Columns.Item("valor_pedido").DataMember = "valor_pedido"
                .RootTable.Columns.Item("nota_fiscal").DataMember = "nota_fiscal"
                .RootTable.Columns.Item("codigo_fornecedor").DataMember = "codigo_fornecedor"
                .RootTable.Columns.Item("codigo_tipo_pedido").DataMember = "codigo_tipo_pedido"
                .RootTable.Columns.Item("codigo_despesa_capa").DataMember = "codigo_despesa_capa"
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


    Public Sub InsertItem(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(8) As SqlParameter
        Dim i As Integer
        Dim oRow() As GridEXRow = oGrid.GetDataRows

        Try

            For i = 0 To UBound(oRow)

                'Seta Parametros - Código Pedido Capa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_pedido_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoPedidoCapa

                'Seta Parametros - Código Item
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_item"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.BigInt
                oSqlParameter(1).Value = oRow(i).Cells("codigo_item").Value

                'Seta Parametros - Código Empresa
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo_empresa"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(2).Value = goUsuario.iEmpresa

                'Seta Parametros - Quantidade
                oSqlParameter(3) = New SqlParameter
                oSqlParameter(3).ParameterName = "quantidade"
                oSqlParameter(3).Direction = ParameterDirection.Input
                oSqlParameter(3).SqlDbType = SqlDbType.Float
                oSqlParameter(3).Value = oRow(i).Cells("quantidade").Value

                'Seta Parametros - Código Unidade Medida
                oSqlParameter(4) = New SqlParameter
                oSqlParameter(4).ParameterName = "codigo_unidade_medida"
                oSqlParameter(4).Direction = ParameterDirection.Input
                oSqlParameter(4).SqlDbType = SqlDbType.Int
                oSqlParameter(4).Value = oRow(i).Cells("codigo_unidade_medida").Value

                'Seta Parametros - Prazo de Entrega
                oSqlParameter(5) = New SqlParameter
                oSqlParameter(5).ParameterName = "prazo_entrega"
                oSqlParameter(5).Direction = ParameterDirection.Input
                oSqlParameter(5).SqlDbType = SqlDbType.Date
                oSqlParameter(5).Value = oRow(i).Cells("prazo_entrega").Value

                'Seta Parametros - Valor Unitário
                oSqlParameter(6) = New SqlParameter
                oSqlParameter(6).ParameterName = "valor_unitario"
                oSqlParameter(6).Direction = ParameterDirection.Input
                oSqlParameter(6).SqlDbType = SqlDbType.Float
                oSqlParameter(6).Value = oRow(i).Cells("valor_unitario").Value

                'Seta Parametros - Código Tipo Calculo Desconto
                oSqlParameter(7) = New SqlParameter
                oSqlParameter(7).ParameterName = "codigo_tipo_calculo_desconto"
                oSqlParameter(7).Direction = ParameterDirection.Input
                oSqlParameter(7).SqlDbType = SqlDbType.Float
                oSqlParameter(7).Value = oRow(i).Cells("codigo_tipo_calculo_desconto").Value

                'Seta Parametros - Desconto
                oSqlParameter(8) = New SqlParameter
                oSqlParameter(8).ParameterName = "desconto"
                oSqlParameter(8).Direction = ParameterDirection.Input
                oSqlParameter(8).SqlDbType = SqlDbType.Float
                oSqlParameter(8).Value = IIf(oRow(i).Cells("codigo_tipo_calculo_desconto").Value = TipoCalculoDesconto.Porcentagem, _
                                             oRow(i).Cells("desconto").Value, _
                                             oRow(i).Cells("desconto").Value * 100 / (oRow(i).Cells("quantidade").Value * oRow(i).Cells("valor_unitario").Value))

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compra_pedido_linha", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteItem()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código Pedido Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_pedido_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoPedidoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_compra_pedido_linha", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridItem(ByVal oGrid As GridEX, _
                            ByVal lCodigoPedidoCapa As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código Pedido Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_pedido_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoPedidoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compra_pedido_linha", oSqlParameter)

            With oGrid

                'Preenche Dados
                .RootTable.Columns.Item("item").DataMember = "item"
                .RootTable.Columns.Item("quantidade").DataMember = "quantidade"
                .RootTable.Columns.Item("unidade_medida").DataMember = "unidade_medida"
                .RootTable.Columns.Item("valor_unitario").DataMember = "valor_unitario"
                .RootTable.Columns.Item("tipo_desconto").DataMember = "tipo_desconto"
                .RootTable.Columns.Item("desconto").DataMember = "desconto"
                .RootTable.Columns.Item("valor_total").DataMember = "valor_total"
                .RootTable.Columns.Item("codigo_item").DataMember = "codigo_item"
                .RootTable.Columns.Item("codigo_unidade_medida").DataMember = "codigo_unidade_medida"
                .RootTable.Columns.Item("codigo_tipo_calculo_desconto").DataMember = "codigo_tipo_calculo_desconto"
                .RootTable.Columns.Item("prazo_entrega").DataMember = "prazo_entrega"
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

    Public Sub InsertItemKitGrid(ByVal oGrid As GridEX, _
                                 ByVal lCodigoItem As Long, _
                                 ByVal dQuantidade As Double, _
                                 ByVal iCodigoTipoCalculoDesconto As Integer, _
                                 ByVal dDesconto As Double, _
                                 ByVal sTipoOperacao As String, _
                                 ByVal sDataEntrega As String, _
                                 ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim oSqlDataReader As SqlDataReader

        Try

            'Seta Parametros - Código Item
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_item_pai"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoItem

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compra_item_estrutura", oSqlParameter)

            While oSqlDataReader.Read

                InsertItemGrid(oGrid, _
                               oSqlDataReader.Item("codigo_referencia"), _
                               oSqlDataReader.Item("codigo_item"), _
                               oSqlDataReader.Item("quantidade") * dQuantidade, _
                               oSqlDataReader.Item("unidade_medida"), _
                               oSqlDataReader.Item("codigo_unidade_medida"), _
                               oSqlDataReader.Item("valor_unitario"), _
                               iCodigoTipoCalculoDesconto, _
                               dDesconto, _
                               CalculaValorTotal(oSqlDataReader.Item("quantidade") * dQuantidade, _
                                                 oSqlDataReader.Item("valor_unitario"), _
                                                 iCodigoTipoCalculoDesconto, _
                                                 dDesconto), _
                               sTipoOperacao, _
                               sDataEntrega, _
                               iCodigo)

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertItemGrid(ByVal oGrid As GridEX, _
                              ByVal sItem As String, _
                              ByVal lCodigoItem As Long, _
                              ByVal dQuantidade As Double, _
                              ByVal sUnidadeMedida As String, _
                              ByVal iCodigoUnidadeMedida As Integer, _
                              ByVal dValorUnitario As Double, _
                              ByVal iTipoDesconto As Integer, _
                              ByVal dDesconto As Double, _
                              ByVal dValorTotal As Double, _
                              ByVal sTipoOperacao As String, _
                              ByVal sDataEntrega As String, _
                              ByVal iCodigo As Integer)

        Try

            'Variaveis Locais
            Dim oDataSet As New DataSet
            Dim oDataTable As New DataTable
            Dim oDataRow As DataRow
            Dim oDCItem As New DataColumn("item")
            Dim oDCQuantidade As New DataColumn("quantidade")
            Dim oDCUnidadeMedida As New DataColumn("unidade_medida")
            Dim oDCPrazoEntrega As New DataColumn("prazo_entrega")
            Dim oDCValorUnitario As New DataColumn("valor_unitario")
            Dim oDCTipoDesconto As New DataColumn("tipo_desconto")
            Dim oDCDesconto As New DataColumn("desconto")
            Dim oDCValorTotal As New DataColumn("valor_total")
            Dim oDCCodigoItem As New DataColumn("codigo_item")
            Dim oDCCodigoUnidadeMedida As New DataColumn("codigo_unidade_medida")
            Dim oDCCodigoTipoCalculoDesconto As New DataColumn("codigo_tipo_calculo_desconto")
            Dim oDCCodigo As New DataColumn("codigo")

            'Verifica se o DataSource é Vazio
            If Not oGrid.DataSource Is Nothing Then
                oDataSet = oGrid.DataSource.DataSet
                oDataTable = oDataSet.Tables(0)
                oGrid.DataSource = Nothing
            Else
                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)
                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCItem)
                oDataTable.Columns.Add(oDCQuantidade)
                oDataTable.Columns.Add(oDCUnidadeMedida)
                oDataTable.Columns.Add(oDCPrazoEntrega)
                oDataTable.Columns.Add(oDCValorUnitario)
                oDataTable.Columns.Add(oDCTipoDesconto)
                oDataTable.Columns.Add(oDCDesconto)
                oDataTable.Columns.Add(oDCValorTotal)
                oDataTable.Columns.Add(oDCCodigoItem)
                oDataTable.Columns.Add(oDCCodigoUnidadeMedida)
                oDataTable.Columns.Add(oDCCodigoTipoCalculoDesconto)
                oDataTable.Columns.Add(oDCCodigo)
                'Seta DataType
                oDCQuantidade.DataType = 0.0.GetType
                oDCValorUnitario.DataType = 0.0.GetType
                oDCDesconto.DataType = 0.0.GetType
                oDCValorTotal.DataType = 0.0.GetType
                oDCPrazoEntrega.DataType = Now.Date.GetType
            End If

            'Verifica o Tipo de Operação
            If sTipoOperacao = "I" Then
                'Adiciona Linhas ao DataTable
                oDataRow = oDataTable.NewRow
                oDataRow("item") = sItem
                oDataRow("quantidade") = dQuantidade
                oDataRow("unidade_medida") = sUnidadeMedida
                oDataRow("valor_unitario") = dValorUnitario
                oDataRow("tipo_desconto") = IIf(iTipoDesconto = TipoCalculoDesconto.Porcentagem, "%", "VALOR")
                oDataRow("desconto") = dDesconto
                oDataRow("valor_total") = dValorTotal
                oDataRow("codigo_item") = lCodigoItem
                oDataRow("codigo_unidade_medida") = iCodigoUnidadeMedida
                oDataRow("codigo_tipo_calculo_desconto") = iTipoDesconto
                oDataRow("prazo_entrega") = IIf(IsDate(sDataEntrega), sDataEntrega, DBNull.Value)
                oDataRow("codigo") = iCodigo
                oDataTable.Rows.Add(oDataRow)
            Else
                oDataRow = oDataTable.Select("(codigo = " & iCodigo & ")")(0)
                oDataRow("item") = sItem
                oDataRow("quantidade") = dQuantidade
                oDataRow("unidade_medida") = sUnidadeMedida
                oDataRow("valor_unitario") = dValorUnitario
                oDataRow("tipo_desconto") = IIf(iTipoDesconto = TipoCalculoDesconto.Porcentagem, "%", "VALOR")
                oDataRow("desconto") = dDesconto
                oDataRow("valor_total") = dValorTotal
                oDataRow("codigo_item") = lCodigoItem
                oDataRow("codigo_unidade_medida") = iCodigoUnidadeMedida
                oDataRow("codigo_tipo_calculo_desconto") = iTipoDesconto
                oDataRow("prazo_entrega") = IIf(IsDate(sDataEntrega), sDataEntrega, DBNull.Value)
                oDataRow("codigo") = iCodigo
            End If

            'Preenche Grid
            With oGrid

                .RootTable.Columns.Item("item").DataMember = "item"
                .RootTable.Columns.Item("quantidade").DataMember = "quantidade"
                .RootTable.Columns.Item("unidade_medida").DataMember = "unidade_medida"
                .RootTable.Columns.Item("valor_unitario").DataMember = "valor_unitario"
                .RootTable.Columns.Item("tipo_desconto").DataMember = "tipo_desconto"
                .RootTable.Columns.Item("desconto").DataMember = "desconto"
                .RootTable.Columns.Item("valor_total").DataMember = "valor_total"
                .RootTable.Columns.Item("codigo_item").DataMember = "codigo_item"
                .RootTable.Columns.Item("codigo_unidade_medida").DataMember = "codigo_unidade_medida"
                .RootTable.Columns.Item("codigo_tipo_calculo_desconto").DataMember = "codigo_tipo_calculo_desconto"
                .RootTable.Columns.Item("prazo_entrega").DataMember = "prazo_entrega"
                .RootTable.Columns.Item("codigo").DataMember = "codigo"

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With

        Catch ex As Exception
            'Trata Erro
            Throw ex
        End Try

    End Sub

    Public Sub LoadDadosItem(ByVal cboItem As UIComboBox, _
                             ByVal cboUnidadeMedida As UIComboBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = cboItem.SelectedValue

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compra_pedido_dados_item", oSqlParameter)

            If oSqlDataReader.HasRows Then

                While oSqlDataReader.Read

                    cboItem.Tag = oSqlDataReader.Item("kit")
                    If oSqlDataReader.Item("kit") = True Then
                        cboUnidadeMedida.Enabled = False : cboUnidadeMedida.SelectedIndex = -1
                    Else
                        cboUnidadeMedida.Enabled = True : cboUnidadeMedida.SelectedValue = oSqlDataReader.Item("codigo_unidade_medida_compra")
                    End If

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


    Public Sub DeleteDuplicata()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_pedido_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoPedidoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_compra_pedido_parcela", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertDuplicata(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(5) As SqlParameter
        Dim oRow() As GridEXRow
        Dim i As Integer

        Try

            oRow = oGrid.GetDataRows

            For i = 0 To UBound(oRow)

                'Seta Parametros - Código Pedido Capa
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_pedido_capa"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = lCodigoPedidoCapa

                'Seta Parametros - Código Empresa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_empresa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(1).Value = goUsuario.iEmpresa

                'Seta Parametros - Data Vencimento
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "pago"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.Bit
                oSqlParameter(2).Value = oRow(i).Cells("pago").Value

                'Seta Parametros - Data Vencimento
                oSqlParameter(3) = New SqlParameter
                oSqlParameter(3).ParameterName = "data_vencimento"
                oSqlParameter(3).Direction = ParameterDirection.Input
                oSqlParameter(3).SqlDbType = SqlDbType.Date
                oSqlParameter(3).Value = oRow(i).Cells("data_vencimento").Value

                'Seta Parametros - Valor
                oSqlParameter(4) = New SqlParameter
                oSqlParameter(4).ParameterName = "valor"
                oSqlParameter(4).Direction = ParameterDirection.Input
                oSqlParameter(4).SqlDbType = SqlDbType.Float
                oSqlParameter(4).Value = oRow(i).Cells("valor").Value

                'Seta Parametros - Número da Parcela
                oSqlParameter(5) = New SqlParameter
                oSqlParameter(5).ParameterName = "numero_parcela"
                oSqlParameter(5).Direction = ParameterDirection.Input
                oSqlParameter(5).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(5).Value = i + 1

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compra_pedido_parcela", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridDuplicata(ByVal oGrid As GridEX, _
                                 ByVal lCodigoPedidoCapa As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código Pedido Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_pedido_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoPedidoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compra_pedido_parcela", oSqlParameter)

            'Preenche Grid
            With oGrid

                .RootTable.Columns.Item("pago").DataMember = "pago"
                .RootTable.Columns.Item("data_vencimento").DataMember = "data_vencimento"
                .RootTable.Columns.Item("valor").DataMember = "valor"

                .DataSource = oDataSet.DefaultViewManager
                .DataMember = oDataSet.Tables(0).TableName

            End With

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub GerarDuplicata(ByVal oGrid As GridEX, _
                              ByVal dValorTotal As Double, _
                              ByVal dDescontoPercentual As Double, _
                              ByVal dDescontoValor As Double, _
                              ByVal iNumeroParcela As Integer, _
                              ByVal iIntervaloParcela As Integer)

        Try

            'Váriaveis Locais
            Dim dValorLiquido As Double

            dValorLiquido = dValorTotal - dDescontoValor - (dDescontoPercentual * dValorTotal / 100)

            'Limpa Grid
            oGrid.DataSource = Nothing

            'Caso Valor Liquido maior que 0
            If dValorLiquido > 0 Then

                'Variaveis Locais
                Dim oDataSet As New DataSet
                Dim oDataTable As New DataTable
                Dim oDCPago As New DataColumn("pago")
                Dim oDCVencimento As New DataColumn("data_vencimento")
                Dim oDCValor As New DataColumn("valor")

                'Seta DataType
                oDCPago.DataType = False.GetType
                oDCVencimento.DataType = Now.Date.GetType
                oDCValor.DataType = 0.0.GetType

                'Adiciona Tabela ao DataSet
                oDataSet.Tables.Add(oDataTable)

                'Adiciona Colunas ao DataTable
                oDataTable.Columns.Add(oDCPago)
                oDataTable.Columns.Add(oDCVencimento)
                oDataTable.Columns.Add(oDCValor)

                'Adiciona Linhas ao DataTable
                For i = 1 To iNumeroParcela
                    Dim oDataRow As DataRow = oDataTable.NewRow
                    oDataRow("pago") = False
                    oDataRow("data_vencimento") = CDate(DateAdd(DateInterval.Day, i * iIntervaloParcela, Now.Date))
                    oDataRow("valor") = dValorLiquido / iNumeroParcela
                    oDataTable.Rows.Add(oDataRow)
                Next

                'Preenche Grid
                With oGrid

                    .RootTable.Columns.Item("pago").DataMember = "pago"
                    .RootTable.Columns.Item("data_vencimento").DataMember = "data_vencimento"
                    .RootTable.Columns.Item("valor").DataMember = "valor"

                    .DataSource = oDataSet.DefaultViewManager
                    .DataMember = oDataSet.Tables(0).TableName

                End With

            End If

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub DeletePagamento()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_pedido_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoPedidoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_compra_pedido_parcela_pagamento", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub


    Public Sub InsertContasPagar()

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código Pedido Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_pedido_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoPedidoCapa

            'Seta Parametros - Código Empresa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_empresa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(1).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_financeiro_despesa_pedido", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class