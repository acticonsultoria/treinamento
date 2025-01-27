Imports System.Data
Imports System.Data.SqlClient
Imports SysACTi.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls

Public Class clsUsrCmpPedidoAprovarReprovar

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe Capa
    Private lCodigoPedidoCapa As Long
    Private iCondicaoPagamento As Integer
    Private iFormaPagamento As Integer
    Private iMoeda As Integer
    Private iTipoFrete As Integer
    Private lTransportadora As Long
    Private dValorFrete As Double
    Private iLocalEntrega As Integer
    Private iModalidadeTransporte As Integer
    Private iIncoterms As Integer
    Private iCertificadoImportacao As Integer
    Private lAgenteLogistico As Long
    Private iInstrucaoEmbarque As Integer
    Private sObservacao As String

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoPedidoCapa() As Long
        Get
            Return lCodigoPedidoCapa
        End Get
        Set(ByVal value As Long)
            lCodigoPedidoCapa = value
        End Set
    End Property

    Public Property Moeda() As Integer
        Get
            Return iMoeda
        End Get
        Set(ByVal value As Integer)
            iMoeda = value
        End Set
    End Property

    Public Property TipoFrete() As Integer
        Get
            Return iTipoFrete
        End Get
        Set(ByVal value As Integer)
            iTipoFrete = value
        End Set
    End Property

    Public Property Transportadora() As Long
        Get
            Return lTransportadora
        End Get
        Set(ByVal value As Long)
            lTransportadora = value
        End Set
    End Property

    Public Property ValorFrete() As Double
        Get
            Return dValorFrete
        End Get
        Set(ByVal value As Double)
            dValorFrete = value
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

    Public Property LocalEntrega() As Integer
        Get
            Return iLocalEntrega
        End Get
        Set(ByVal value As Integer)
            iLocalEntrega = value
        End Set
    End Property

    Public Property CondicaoPagamento() As Integer
        Get
            Return iCondicaoPagamento
        End Get
        Set(ByVal value As Integer)
            iCondicaoPagamento = value
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

    Public Property Incoterms() As Integer
        Get
            Return iIncoterms
        End Get
        Set(ByVal value As Integer)
            iIncoterms = value
        End Set
    End Property

    Public Property CertificadoImportaca() As Integer
        Get
            Return iCertificadoImportacao
        End Get
        Set(ByVal value As Integer)
            iCertificadoImportacao = value
        End Set
    End Property

    Public Property CodigoAgenteLogistico() As Long
        Get
            Return lAgenteLogistico
        End Get
        Set(ByVal value As Long)
            lAgenteLogistico = value
        End Set
    End Property

    Public Property CodigoInstrucaoEmbarque() As Integer
        Get
            Return iInstrucaoEmbarque
        End Get
        Set(ByVal value As Integer)
            iInstrucaoEmbarque = value
        End Set
    End Property

    Public Property ModalidadeTransporte() As Integer
        Get
            Return iModalidadeTransporte
        End Get
        Set(ByVal value As Integer)
            iModalidadeTransporte = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub LoadDadosPedidoCapa(ByVal lCodigo As Long, _
                                   ByVal txtDataPedido As EditBox, _
                                   ByVal txtFornecedor As EditBox, _
                                   ByVal txtUsuario As EditBox, _
                                   ByVal cboMoeda As UIComboBox, _
                                   ByVal cboTipoFrete As UIComboBox, _
                                   ByVal cboTransportadora As UIComboBox, _
                                   ByVal txtValorFrete As NumericEditBox, _
                                   ByVal cboFormaPagamento As UIComboBox, _
                                   ByVal cboLocalEntrega As UIComboBox, _
                                   ByVal cboCondicaoPagamento As UIComboBox, _
                                   ByVal cboModalidadeTransporte As UIComboBox, _
                                   ByVal cboIncoterms As UIComboBox, _
                                   ByVal cboCertificadoImportacao As UIComboBox, _
                                   ByVal cboAgenteLogistico As UIComboBox, _
                                   ByVal cboInstrucaoEmbarque As UIComboBox, _
                                   ByVal txtObservacao As EditBox, _
                                   ByVal txtObservacaoAprovacao As EditBox)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(0) As SqlParameter

        Try

            'Seta Parametros - Código Pedido Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_pedido_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigo

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_dados_pedido", oSqlParameter)

            While oSqlDataReader.Read

                txtDataPedido.Text = oSqlDataReader.Item("data_pedido")
                txtFornecedor.Text = oSqlDataReader.Item("fornecedor")
                txtFornecedor.Tag = oSqlDataReader.Item("codigo_fornecedor")
                txtUsuario.Text = oSqlDataReader.Item("usuario")
                cboMoeda.SelectedValue = oSqlDataReader.Item("codigo_moeda")
                cboTipoFrete.SelectedValue = oSqlDataReader.Item("codigo_tipo_frete")
                cboTransportadora.SelectedValue = oSqlDataReader.Item("codigo_transportadora")
                txtValorFrete.Value = oSqlDataReader.Item("valor_frete")
                cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento")
                cboLocalEntrega.SelectedValue = oSqlDataReader.Item("codigo_local_entrega")
                cboCondicaoPagamento.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento")
                cboModalidadeTransporte.SelectedValue = oSqlDataReader.Item("codigo_modalidade_transporte")
                cboIncoterms.SelectedValue = oSqlDataReader.Item("codigo_incoterms")
                cboCertificadoImportacao.SelectedValue = oSqlDataReader.Item("codigo_certificado_importacao")
                cboAgenteLogistico.SelectedValue = oSqlDataReader.Item("codigo_agente_logistico")
                cboInstrucaoEmbarque.SelectedValue = oSqlDataReader.Item("codigo_instrucao_embarque")
                txtObservacao.Text = oSqlDataReader.Item("observacao").ToString
                txtObservacaoAprovacao.Text = oSqlDataReader.Item("observacao_aprovacao")

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdatePedidoCapa()

        'Variaveis Locais
        Dim oSqlParameter(13) As SqlParameter

        Try

            'Seta Parametros - Código Condição de Pagamento
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_condicao_pagamento"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCondicaoPagamento

            'Seta Parametros - Forma de Pagamento
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_forma_pagamento"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = iFormaPagamento

            'Seta Parametros - Código Moeda
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_moeda"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iMoeda

            'Seta Parametros - Código Tipo Frete
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo_tipo_frete"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(3).Value = iTipoFrete

            'Seta Parametros - Código Transportadora
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo_transportadora"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.BigInt
            oSqlParameter(4).Value = IIf(lTransportadora = -1, DBNull.Value, lTransportadora)

            'Seta Parametros - Valor Frete
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "valor_frete"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Float
            oSqlParameter(5).Value = dValorFrete

            'Seta Parametros - Código Local Entrega
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "codigo_local_entrega"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.Int
            oSqlParameter(6).Value = IIf(iLocalEntrega = -1, DBNull.Value, iLocalEntrega)

            'Seta Parametros - Código Modalidade Transporte
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "codigo_modalidade_transporte"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.Int
            oSqlParameter(7).Value = IIf(iModalidadeTransporte = -1, DBNull.Value, iModalidadeTransporte)

            'Seta Parametros - Código Incoterms
            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "codigo_incoterms"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.Int
            oSqlParameter(8).Value = IIf(iIncoterms = -1, DBNull.Value, iIncoterms)

            'Seta Parametros - Código Certificado Importação
            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "codigo_certificado_importacao"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.Int
            oSqlParameter(9).Value = IIf(iCertificadoImportacao = -1, DBNull.Value, iCertificadoImportacao)

            'Seta Parametros - Código Agente Logístico
            oSqlParameter(10) = New SqlParameter
            oSqlParameter(10).ParameterName = "codigo_agente_logistico"
            oSqlParameter(10).Direction = ParameterDirection.Input
            oSqlParameter(10).SqlDbType = SqlDbType.BigInt
            oSqlParameter(10).Value = IIf(lAgenteLogistico = -1, DBNull.Value, lAgenteLogistico)


            'Seta Parametros - Código Instrucao Embaruqe
            oSqlParameter(11) = New SqlParameter
            oSqlParameter(11).ParameterName = "codigo_instrucao_embarque"
            oSqlParameter(11).Direction = ParameterDirection.Input
            oSqlParameter(11).SqlDbType = SqlDbType.Int
            oSqlParameter(11).Value = IIf(iInstrucaoEmbarque = -1, DBNull.Value, iInstrucaoEmbarque)


            'Seta Parametros - Observação
            oSqlParameter(12) = New SqlParameter
            oSqlParameter(12).ParameterName = "observacao"
            oSqlParameter(12).Direction = ParameterDirection.Input
            oSqlParameter(12).SqlDbType = SqlDbType.Text
            oSqlParameter(12).Value = IIf(sObservacao = "", DBNull.Value, sObservacao)

            'Seta Parametros - Código
            oSqlParameter(13) = New SqlParameter
            oSqlParameter(13).ParameterName = "codigo_pedido_capa"
            oSqlParameter(13).Direction = ParameterDirection.Input
            oSqlParameter(13).SqlDbType = SqlDbType.BigInt
            oSqlParameter(13).Value = lCodigoPedidoCapa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_pedido_capa", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridPedidoLinha(ByVal oGrid As GridEX, _
                                   ByVal lCodigoPedidoCapa As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(0) As SqlParameter

        Try

            'Seta Parametros - Código Pedido Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_pedido_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoPedidoCapa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_pedido_linha", oSqlParameter)

            With oGrid

                .RootTable.Columns.Item("item").DataMember = "item"
                .RootTable.Columns.Item("marca").DataMember = "marca"
                .RootTable.Columns.Item("quantidade").DataMember = "quantidade"
                .RootTable.Columns.Item("valor_unitario").DataMember = "valor_unitario"
                .RootTable.Columns.Item("unidade_medida").DataMember = "unidade_medida"
                .RootTable.Columns.Item("ipi_incluso").DataMember = "ipi_incluso"
                .RootTable.Columns.Item("icms_incluso").DataMember = "icms_incluso"
                .RootTable.Columns.Item("tipo_visualizacao_desconto").DataMember = "tipo_visualizacao_desconto"
                .RootTable.Columns.Item("desconto").DataMember = "porcentagem_desconto"
                .RootTable.Columns.Item("ipi").DataMember = "ipi"
                .RootTable.Columns.Item("icms").DataMember = "icms"
                .RootTable.Columns.Item("prazo_entrega").DataMember = "prazo_entrega"
                .RootTable.Columns.Item("valor_total").DataMember = "valor_total"
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

    Public Sub UpdatePedidoLinha(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(10) As SqlParameter
        Dim oRow() As GridEXRow
        Dim i As Integer

        Try

            'Obtem Linhas
            oRow = oGrid.GetDataRows

            For i = 0 To UBound(oRow)

                'Seta Parametros - Marca
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "marca"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.VarChar
                oSqlParameter(0).Value = oRow(i).Cells("marca").Value

                'Seta Parametros - Quantidade
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "quantidade"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.Float
                oSqlParameter(1).Value = oRow(i).Cells("quantidade").Value

                'Seta Parametros - Valor Unitário
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "valor_unitario"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.Money
                oSqlParameter(2).Value = oRow(i).Cells("valor_unitario").Value

                'Seta Parametros - IPI Incluso
                oSqlParameter(3) = New SqlParameter
                oSqlParameter(3).ParameterName = "ipi_incluso"
                oSqlParameter(3).Direction = ParameterDirection.Input
                oSqlParameter(3).SqlDbType = SqlDbType.Bit
                oSqlParameter(3).Value = oRow(i).Cells("ipi_incluso").Value

                'Seta Parametros - ICMS Incluso
                oSqlParameter(4) = New SqlParameter
                oSqlParameter(4).ParameterName = "icms_incluso"
                oSqlParameter(4).Direction = ParameterDirection.Input
                oSqlParameter(4).SqlDbType = SqlDbType.Bit
                oSqlParameter(4).Value = oRow(i).Cells("icms_incluso").Value

                'Seta Parametros - IPI
                oSqlParameter(5) = New SqlParameter
                oSqlParameter(5).ParameterName = "ipi"
                oSqlParameter(5).Direction = ParameterDirection.Input
                oSqlParameter(5).SqlDbType = SqlDbType.Float
                oSqlParameter(5).Value = oRow(i).Cells("ipi").Value

                'Seta Parametros - ICMS
                oSqlParameter(6) = New SqlParameter
                oSqlParameter(6).ParameterName = "icms"
                oSqlParameter(6).Direction = ParameterDirection.Input
                oSqlParameter(6).SqlDbType = SqlDbType.Float
                oSqlParameter(6).Value = oRow(i).Cells("icms").Value

                'Seta Parametros - Tipo de Visualização de Desconto
                oSqlParameter(7) = New SqlParameter
                oSqlParameter(7).ParameterName = "tipo_visualizacao_desconto"
                oSqlParameter(7).Direction = ParameterDirection.Input
                oSqlParameter(7).SqlDbType = SqlDbType.Char
                oSqlParameter(7).Size = 1
                oSqlParameter(7).Value = oRow(i).Cells("tipo_visualizacao_desconto").Value

                'Seta Parametros - Desconto
                oSqlParameter(8) = New SqlParameter
                oSqlParameter(8).ParameterName = "porcentagem_desconto"
                oSqlParameter(8).Direction = ParameterDirection.Input
                oSqlParameter(8).SqlDbType = SqlDbType.Float
                oSqlParameter(8).Value = oRow(i).Cells("desconto").Value

                'Seta Parametros - Prazo Entrega
                oSqlParameter(9) = New SqlParameter
                oSqlParameter(9).ParameterName = "prazo_entrega"
                oSqlParameter(9).Direction = ParameterDirection.Input
                oSqlParameter(9).SqlDbType = SqlDbType.Date
                oSqlParameter(9).Value = oRow(i).Cells("prazo_entrega").Value

                'Seta Parametros - Código
                oSqlParameter(10) = New SqlParameter
                oSqlParameter(10).ParameterName = "codigo"
                oSqlParameter(10).Direction = ParameterDirection.Input
                oSqlParameter(10).SqlDbType = SqlDbType.BigInt
                oSqlParameter(10).Value = oRow(i).Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_pedido_linha", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub AprovarPedido(ByVal lCodigoPedido As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código do Pedido
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoPedido

            'Seta Parametros - Código Usuário
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_usuario"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_pedido_aprovar", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub ReprovarPedido(ByVal lCodigoPedido As Long)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter

        Try

            'Seta Parametros - Código do Pedido
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoPedido

            'Seta Parametros - Código Usuário
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_usuario"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = goUsuario.iUsuario

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_pedido_reprovar", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class

