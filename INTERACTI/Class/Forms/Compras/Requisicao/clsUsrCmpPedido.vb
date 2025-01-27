Imports System.Data
Imports System.Data.SqlClient
Imports SysACTi.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.EditControls
Imports Microsoft.Office.Interop.Excel

Public Class clsUsrCmpPedido

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
    Private lNumeroPedido As Long

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

    Public Property NumeroPedido() As Long
        Get
            Return lNumeroPedido
        End Get
        Set(ByVal value As Long)
            lNumeroPedido = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub EnviarEmailComprasPendente()

        Try


            'Variaveis Local
            Dim oSqlDataReader As SqlDataReader
            Dim oApplicationClass As New ApplicationClass
            Dim oWorkbook As Workbook
            Dim oWorksheet As Worksheet
            Dim sEmail As String = ""
            Dim sCorpo As String = ""
            Dim iRow As Integer = 0
            Dim sCaminho As String

            oWorkbook = oApplicationClass.Workbooks.Add()
            oWorksheet = oWorkbook.ActiveSheet()

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_email_pendente")

            'Carrega Cabeçalho
            If oSqlDataReader.HasRows = True Then

                oApplicationClass.Cells(1, 1) = "PO"
                oApplicationClass.Cells(1, 2) = "Fornecedor"
                oApplicationClass.Cells(1, 3) = "Solicitante"
                oApplicationClass.Cells(1, 4) = "Part Number"
                oApplicationClass.Cells(1, 5) = "Item"
                oApplicationClass.Cells(1, 6) = "Justificativa"
                oApplicationClass.Cells(1, 7) = "Qtd Pedido"
                oApplicationClass.Cells(1, 8) = "Pendente"
                oApplicationClass.Cells(1, 9) = "Data Pedido"
                oApplicationClass.Cells(1, 10) = "Prazo Entrega"
                oApplicationClass.Cells(1, 11) = "Atraso"

                For i = 1 To 11
                    oWorksheet.Cells(1, i).Font.Bold = True
                Next


            End If


            While oSqlDataReader.Read()

                'Recebendo as informações
                sCorpo = oSqlDataReader.Item("mascara")
                sEmail = oSqlDataReader.Item("email")

                oApplicationClass.Cells(iRow + 2, 1) = oSqlDataReader.Item("po")
                oApplicationClass.Cells(iRow + 2, 2) = oSqlDataReader.Item("fornecedor")
                oApplicationClass.Cells(iRow + 2, 3) = oSqlDataReader.Item("solicitante")
                oApplicationClass.Cells(iRow + 2, 4) = oSqlDataReader.Item("part_number")
                oApplicationClass.Cells(iRow + 2, 5) = oSqlDataReader.Item("item")
                oApplicationClass.Cells(iRow + 2, 6) = oSqlDataReader.Item("justificativa")
                oApplicationClass.Cells(iRow + 2, 7) = oSqlDataReader.Item("quantidade_pedido")
                oApplicationClass.Cells(iRow + 2, 8) = oSqlDataReader.Item("quantidade_pendente")
                oApplicationClass.Cells(iRow + 2, 9) = oSqlDataReader.Item("data_pedido")
                oApplicationClass.Cells(iRow + 2, 10) = oSqlDataReader.Item("prazo_entrega")
                oApplicationClass.Cells(iRow + 2, 11) = oSqlDataReader.Item("atraso")

                'Incrementando o contador
                iRow += 1

            End While

            oSqlDataReader.Close()

          


            'Enviando o e-mail
            If Len(sCorpo) > 0 Then

                sCaminho = ApplicationPath() & "File\Pedidos Atrasados\Pedidos em " & Format(Now, "dd_MM_yyyy") & ".xlsx"

                'Salvando         
                oWorksheet.Columns.AutoFit()
                oWorkbook.SaveAs(sCaminho)
                oWorkbook.Close()

                EnviarEmailExchange(sEmail, _
                           "Pedidos em Atraso - " & Format(Now, "dd/MM/yyyy"), _
                           sCorpo, _
                           sCaminho)

            End If


        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    'Public Sub EnviarEmailComprasPendente()

    '    Dim oSqlDataReader As SqlDataReader

    '    Try

    '        'Usuários Administradores 
    '        If goUsuario.iPerfil = 1 Then Exit Sub

    '        'Executa Query
    '        oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_email_pendente")

    '        Dim sEmail As String = ""
    '        Dim sCorpo As String = ""

    '        While oSqlDataReader.Read()

    '            sCorpo = oSqlDataReader.Item("mascara")
    '            sEmail = oSqlDataReader.Item("email")



    '            sItem += "<tr align=center>"

    '            sItem += "<td>" & oSqlDataReader.Item("po") & "</td>"
    '            sItem += "<td align=left>" & oSqlDataReader.Item("fornecedor") & "</td>"
    '            sItem += "<td>" & oSqlDataReader.Item("solicitante") & "</td>"
    '            sItem += "<td align=left>" & oSqlDataReader.Item("part_number") & "</td>"
    '            sItem += "<td align=left>" & oSqlDataReader.Item("item") & "</td>"
    '            sItem += "<td align=left>" & oSqlDataReader.Item("justificativa") & "</td>"
    '            sItem += "<td>" & oSqlDataReader.Item("quantidade_pedido") & "</td>"
    '            sItem += "<td>" & oSqlDataReader.Item("quantidade_pendente") & "</td>"
    '            sItem += "<td>" & oSqlDataReader.Item("data_pedido") & "</td>"
    '            sItem += "<td>" & oSqlDataReader.Item("prazo_entrega") & "</td>"
    '            sItem += "<td>" & oSqlDataReader.Item("atraso") & "</td>"

    '            sItem += "</tr>"


    '        End While

    '        oSqlDataReader.Close()


    '        'If Len(sCorpo) > 0 Then

    '        '    EnviarEmailExchange(sEmail, _
    '        '               "Pedidos em Atraso - " & Format(Now, "dd/MM/yyyy"), _
    '        '               sCorpo, _
    '        '               "")

    '        'End If


    '    Catch SqlEx As SqlException
    '        Throw SqlEx
    '    Catch ex As Exception
    '        Throw ex
    '    End Try

    'End Sub

    Public Sub LoadGridListagem(ByVal oGrid As GridEX, _
                                ByVal lNumeroPedido As Long, _
                                ByVal sNumeroCotacao As String, _
                                ByVal iFornecedor As Integer, _
                                ByVal iCondicaoPagamento As Integer, _
                                ByVal sDataPedido1 As String, _
                                ByVal sDataPedido2 As String, _
                                ByVal iStatus As Integer, _
                                ByVal sPartNumber As String, _
                                ByVal sItem As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(9) As SqlParameter

        Try

            'Seta Parametros - Número do Pedido
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "numero_pedido"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lNumeroPedido

            'Seta Parametros - Número da Cotação
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "numero_cotacao"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.VarChar
            oSqlParameter(1).Size = 500
            oSqlParameter(1).Value = sNumeroCotacao

            'Seta Parametros - Código Fornecedor
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_fornecedor"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Int
            oSqlParameter(2).Value = iFornecedor

            'Seta Parametros - Data do Pedido 1
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "data_pedido1"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.Date
            oSqlParameter(3).Value = IIf(sDataPedido1 = "", DBNull.Value, sDataPedido1)

            'Seta Parametros - Data do Pedido 2
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "data_pedido2"
            oSqlParameter(4).Direction = ParameterDirection.Input
            oSqlParameter(4).SqlDbType = SqlDbType.Date
            oSqlParameter(4).Value = IIf(sDataPedido2 = "", DBNull.Value, sDataPedido2)

            'Seta Parametros - Código Condição de Pagamento
            oSqlParameter(5) = New SqlParameter
            oSqlParameter(5).ParameterName = "codigo_condicao_pagamento"
            oSqlParameter(5).Direction = ParameterDirection.Input
            oSqlParameter(5).SqlDbType = SqlDbType.Int
            oSqlParameter(5).Value = iCondicaoPagamento

            'Seta Parametros - Status
            oSqlParameter(6) = New SqlParameter
            oSqlParameter(6).ParameterName = "status"
            oSqlParameter(6).Direction = ParameterDirection.Input
            oSqlParameter(6).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(6).Value = iStatus

            'Seta Parametros - Empresa
            oSqlParameter(7) = New SqlParameter
            oSqlParameter(7).ParameterName = "codigo_empresa"
            oSqlParameter(7).Direction = ParameterDirection.Input
            oSqlParameter(7).SqlDbType = SqlDbType.Int
            oSqlParameter(7).Value = goUsuario.iEmpresa

            'Seta Parametros - Part Number
            oSqlParameter(8) = New SqlParameter
            oSqlParameter(8).ParameterName = "part_number"
            oSqlParameter(8).Direction = ParameterDirection.Input
            oSqlParameter(8).SqlDbType = SqlDbType.VarChar
            oSqlParameter(8).Value = sPartNumber

            'Seta Parametros - Item
            oSqlParameter(9) = New SqlParameter
            oSqlParameter(9).ParameterName = "item"
            oSqlParameter(9).Direction = ParameterDirection.Input
            oSqlParameter(9).SqlDbType = SqlDbType.VarChar
            oSqlParameter(9).Value = sItem

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_pedido", oSqlParameter)

            With oGrid

                .RootTable.Columns.Item("numero_pedido").DataMember = "numero_pedido"
                .RootTable.Columns.Item("numero_cotacao").DataMember = "numero_cotacao"
                .RootTable.Columns.Item("data_pedido").DataMember = "data_pedido"
                .RootTable.Columns.Item("fornecedor").DataMember = "fornecedor"
                .RootTable.Columns.Item("condicao_pagamento").DataMember = "condicao_pagamento"
                .RootTable.Columns.Item("valor_total").DataMember = "valor_total"
                .RootTable.Columns.Item("codigo_fornecedor").DataMember = "codigo_fornecedor"
                .RootTable.Columns.Item("codigo_cotacao_capa").DataMember = "codigo_cotacao_capa"
                .RootTable.Columns.Item("usuario").DataMember = "usuario"
                .RootTable.Columns.Item("status").DataMember = "status"
                .RootTable.Columns.Item("contato").DataMember = "contato"
                .RootTable.Columns.Item("observacao_aprovacao").DataMember = "observacao_aprovacao"
                .RootTable.Columns.Item("codigo_pais").DataMember = "codigo_pais"
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

    Public Sub LoadGridDuplicata(ByVal oGrid As GridEX, _
                               ByVal iCondicaoPagamento As Integer, _
                               ByVal dValorTotal As Double, _
                               ByVal lCodigo As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(3) As SqlParameter

        Try

            'Seta Parametros - Código Condição Pagamento
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_condicao_pagamento"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = iCondicaoPagamento

            'Seta Parametros - Código Pedido Capa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_pedido_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = lCodigo

            'Seta Parametros - Valor Total
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "valor_total"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Float
            oSqlParameter(2).Value = dValorTotal


            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_compras_pedido_gerar_duplicata", oSqlParameter)

            With oGrid

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

    Public Sub LoadDadosPedidoCapa(ByVal lCodigo As Long, _
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
                                   ByVal txtObservacao As Janus.Windows.GridEX.EditControls.EditBox)

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

            End While

            'Fecha o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close()

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Function ValidaSequencia() As Boolean

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter
        Dim iReturn As Integer

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_compras_numero_pedido", oSqlParameter), Integer)

            'Seta Retorno da Função
            ValidaSequencia = IIf(iReturn > 0, False, True)


        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub InsertPedidoCapa()

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros - Código Usuário
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_usuario"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = goUsuario.iUsuario

            'Seta Parametros - Código Fornecedor
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_fornecedor"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.BigInt
            oSqlParameter(2).Value = gSelecaoRow(0).Cells("codigo_fornecedor").Value

            'Seta Parametros - Código do Pedido
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "codigo"
            oSqlParameter(3).Direction = ParameterDirection.Output
            oSqlParameter(3).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_pedido_capa", oSqlParameter)

            'Seta Retorno da Função
            lCodigoPedidoCapa = oSqlParameter(3).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertPedidoParcela(ByVal oGrid As GridEX)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try

            For Each oRow As GridEXRow In oGrid.GetRows

                'Seta Parametros - Data Vencimento
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "data_vencimento"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.Date
                oSqlParameter(0).Value = oRow.Cells.Item("data_vencimento").Value

                'Seta Parametros - Valor
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "valor"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.Float
                oSqlParameter(1).Value = oRow.Cells.Item("valor").Value

                'Seta Parametros - Código do Pedido
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo_pedido_capa"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.BigInt
                oSqlParameter(2).Value = lCodigoPedidoCapa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_pedido_parcela", oSqlParameter)


            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub CancelarPedidoLinha(ByVal lCodigoPedidoLinha As Long, _
                                   ByVal dQtdCancelada As Double, _
                                   ByVal dValorUnitario As Double)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try


            'Seta Parametros - Código Pedido Linha
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_pedido_linha"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoPedidoLinha

            'Seta Parametros - Quantidade Cancelada
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "quantidade_cancelada"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Float
            oSqlParameter(1).Value = dQtdCancelada

            'Seta Parametros - Valor Unitário
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "valor_unitario"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.Float
            oSqlParameter(2).Value = dValorUnitario


            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_pedido_linha_cancelar", oSqlParameter)



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeletePedidoParcela()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter

        Try

            'Seta Parametros - Código Pedido Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_pedido_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoPedidoCapa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_compras_pedido_parcela", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertPedidoCapa2()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter

        Try

            'Seta Parametros - Código Empresa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_empresa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.Int
            oSqlParameter(0).Value = goUsuario.iEmpresa

            'Seta Parametros - Código Usuário
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_usuario"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = goUsuario.iUsuario

            'Seta Parametros - Código Fornecedor
            oSqlParameter(2) = New SqlParameter
            oSqlParameter(2).ParameterName = "codigo_fornecedor"
            oSqlParameter(2).Direction = ParameterDirection.Input
            oSqlParameter(2).SqlDbType = SqlDbType.BigInt
            oSqlParameter(2).Value = gSelecaoRow(0).Cells("codigo_fornecedor").Value

            'Seta Parametros - Número Pedido
            oSqlParameter(3) = New SqlParameter
            oSqlParameter(3).ParameterName = "numero_pedido"
            oSqlParameter(3).Direction = ParameterDirection.Input
            oSqlParameter(3).SqlDbType = SqlDbType.BigInt
            oSqlParameter(3).Value = NumeroPedido

            'Seta Parametros - Código do Pedido
            oSqlParameter(4) = New SqlParameter
            oSqlParameter(4).ParameterName = "codigo"
            oSqlParameter(4).Direction = ParameterDirection.Output
            oSqlParameter(4).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_pedido_capa2", oSqlParameter)

            'Seta Retorno da Função
            lCodigoPedidoCapa = oSqlParameter(4).Value

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

    Public Sub UpdatePedidoCapa1()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For i = 0 To UBound(gSelecaoRow)

                'Seta Parametros - Código Fornecedor
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "codigo_fornecedor"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = gSelecaoRow(i).Cells("codigo_fornecedor").Value

                'Seta Parametros - Código Cotação Capa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "codigo_cotacao_capa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.BigInt
                oSqlParameter(1).Value = gSelecaoRow(i).Cells("codigo_cotacao_capa").Value

                'Seta Parametros - Código Pedido Capa
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo_pedido_capa"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.BigInt
                oSqlParameter(2).Value = lCodigoPedidoCapa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_pedido_capa1", oSqlParameter)

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub VoltarCotacao()

        'Variaveis Locais
        Dim oSqlParameter(0) As SqlParameter

        Try

            'Seta Parametros - Código Pedido Capa
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_pedido_capa"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.BigInt
            oSqlParameter(0).Value = lCodigoPedidoCapa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_pedido_cotacao", oSqlParameter)

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
                .RootTable.Columns.Item("prazo_entrega").DataMember = "prazo_entrega"
                .RootTable.Columns.Item("unidade_medida").DataMember = "unidade_medida"
                .RootTable.Columns.Item("quantidade").DataMember = "quantidade"
                .RootTable.Columns.Item("valor_unitario").DataMember = "valor_unitario"
                .RootTable.Columns.Item("ipi_incluso").DataMember = "ipi_incluso"
                .RootTable.Columns.Item("icms_incluso").DataMember = "icms_incluso"
                .RootTable.Columns.Item("tipo_desconto").DataMember = "tipo_visualizacao_desconto"
                .RootTable.Columns.Item("desconto").DataMember = "porcentagem_desconto"
                .RootTable.Columns.Item("ipi").DataMember = "ipi"
                .RootTable.Columns.Item("icms").DataMember = "icms"
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

    Public Sub LoadGridPedidoLinhaAtualizar(ByVal oGrid As GridEX, _
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
                .RootTable.Columns.Item("quantidade_pedido").DataMember = "quantidade_pedido"
                .RootTable.Columns.Item("quantidade_entregue").DataMember = "quantidade_entregue"
                .RootTable.Columns.Item("quantidade_cancelada").DataMember = "quantidade_cancelada"
                .RootTable.Columns.Item("quantidade_pendente").DataMember = "quantidade_pendente"
                .RootTable.Columns.Item("valor_unitario").DataMember = "valor_unitario"
                .RootTable.Columns.Item("ipi_incluso").DataMember = "ipi_incluso"
                .RootTable.Columns.Item("icms_incluso").DataMember = "icms_incluso"
                .RootTable.Columns.Item("tipo_desconto").DataMember = "tipo_visualizacao_desconto"
                .RootTable.Columns.Item("desconto").DataMember = "porcentagem_desconto"
                .RootTable.Columns.Item("ipi").DataMember = "ipi"
                .RootTable.Columns.Item("icms").DataMember = "icms"
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

    Public Sub InsertPedidoLinha()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter

        Try

            For i = 0 To UBound(gSelecaoRow)

                'Seta Parametros - Código Fornecedor
                oSqlParameter(0) = New SqlParameter
                oSqlParameter(0).ParameterName = "@codigo_fornecedor"
                oSqlParameter(0).Direction = ParameterDirection.Input
                oSqlParameter(0).SqlDbType = SqlDbType.BigInt
                oSqlParameter(0).Value = gSelecaoRow(i).Cells("codigo_fornecedor").Value

                'Seta Parametros - Código Cotação Capa
                oSqlParameter(1) = New SqlParameter
                oSqlParameter(1).ParameterName = "@codigo_cotacao_capa"
                oSqlParameter(1).Direction = ParameterDirection.Input
                oSqlParameter(1).SqlDbType = SqlDbType.BigInt
                oSqlParameter(1).Value = gSelecaoRow(i).Cells("codigo_cotacao_capa").Value

                'Seta Parametros - Código Pedido Capa
                oSqlParameter(2) = New SqlParameter
                oSqlParameter(2).ParameterName = "codigo_pedido_capa"
                oSqlParameter(2).Direction = ParameterDirection.Input
                oSqlParameter(2).SqlDbType = SqlDbType.BigInt
                oSqlParameter(2).Value = lCodigoPedidoCapa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_compras_pedido_linha", oSqlParameter)

            Next

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
                oSqlParameter(7).Value = oRow(i).Cells("tipo_desconto").Value

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

    Public Function LoadEmailPedido(ByVal lCodigoPedidoCapa As Long, _
                                    ByVal iPais As Integer) As String

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim sReturn As String

        Try

            'Seta Parametros - Código da cotação do fornecedor linha
            oSqlParameter(0) = New SqlParameter
            oSqlParameter(0).ParameterName = "codigo_email"
            oSqlParameter(0).Direction = ParameterDirection.Input
            oSqlParameter(0).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(0).Value = IIf(iPais = Pais.Brasil, MascaraEmail.PedidoCompraNacional, MascaraEmail.PedidoCompraInternacional)

            'Seta Parametros - Código Pedido Capa
            oSqlParameter(1) = New SqlParameter
            oSqlParameter(1).ParameterName = "codigo_pedido_capa"
            oSqlParameter(1).Direction = ParameterDirection.Input
            oSqlParameter(1).SqlDbType = SqlDbType.BigInt
            oSqlParameter(1).Value = lCodigoPedidoCapa

            'Executa Query
            sReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_configuracao_mascara_email_pedido", oSqlParameter), String)

            Return sReturn

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Sub AtualizarPrevisaoPedido(ByVal lCodigoPedidoCapa As Long)

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
            oSqlParameter(1).SqlDbType = SqlDbType.Int
            oSqlParameter(1).Value = goUsuario.iEmpresa



            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_compras_pedido_financeiro_previsao", oSqlParameter)



        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

End Class

