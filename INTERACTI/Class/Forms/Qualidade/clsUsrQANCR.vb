Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo

Public Class clsUsrQANCR

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe

    Private lCodigoPedido As Long
    Private iCodigoPedidoItem As Integer
    Private iCodigoPedidoItemEntrega As Integer
    Private sNcSobNo As String
    Private iStatus As Integer
    Private sFluxo As String
    Private lCodigoCliente As Long
    Private iCodigoResponsavelAbertura As Integer
    Private sDataAbertura As String
    Private sRFP As String
    Private sNumeroPO As String
    Private sPartNumber As String
    Private sSerialNumber As String
    Private iQuantidade As Integer
    Private lCodigoPrestador As Long
    Private iCodigoResponsavelFechamento As Integer
    Private sPOFornecedor As String
    Private sDelta As String
    Private iCodigo As Integer
    Private iCodigoDefeito As Integer

#End Region

#Region "::: PROPERTIE :::"

    Public Property CodigoDefeito() As Integer
        Get
            Return iCodigoDefeito
        End Get
        Set(ByVal value As Integer)
            iCodigoDefeito = value
        End Set
    End Property

    Public Property CodigoPedido() As Long
        Get
            Return lCodigoPedido
        End Get
        Set(ByVal value As Long)
            lCodigoPedido = value
        End Set
    End Property

    Public Property CodigoPedidoItem() As Integer
        Get
            Return iCodigoPedidoItem
        End Get
        Set(ByVal value As Integer)
            iCodigoPedidoItem = value
        End Set
    End Property

    Public Property CodigoPedidoItemEntrega() As Integer
        Get
            Return iCodigoPedidoItemEntrega
        End Get
        Set(ByVal value As Integer)
            iCodigoPedidoItemEntrega = value
        End Set
    End Property

    Public Property NcSobNo() As String
        Get
            Return sNcSobNo
        End Get
        Set(ByVal value As String)
            sNcSobNo = value
        End Set
    End Property

    Public Property RFP() As String
        Get
            Return sRFP
        End Get
        Set(ByVal value As String)
            sRFP = value
        End Set
    End Property

    Public Property Status() As Integer
        Get
            Return iStatus
        End Get
        Set(ByVal value As Integer)
            iStatus = value
        End Set
    End Property

    Public Property Fluxo() As String
        Get
            Return sFluxo
        End Get
        Set(ByVal value As String)
            sFluxo = value
        End Set
    End Property

    Public Property CodigoCliente() As Long
        Get
            Return lCodigoCliente
        End Get
        Set(ByVal value As Long)
            lCodigoCliente = value
        End Set
    End Property

    Public Property CodigoResponsavelAbertura() As Integer
        Get
            Return iCodigoResponsavelAbertura
        End Get
        Set(ByVal value As Integer)
            iCodigoResponsavelAbertura = value
        End Set
    End Property

    Public Property DataAbertura() As String
        Get
            Return sDataAbertura
        End Get
        Set(ByVal value As String)
            sDataAbertura = value
        End Set
    End Property

    Public Property NumeroPO() As String
        Get
            Return sNumeroPO
        End Get
        Set(ByVal value As String)
            sNumeroPO = value
        End Set
    End Property

    Public Property PartNumber() As String
        Get
            Return sPartNumber
        End Get
        Set(ByVal value As String)
            sPartNumber = value
        End Set
    End Property

    Public Property SerialNumber() As String
        Get
            Return sSerialNumber
        End Get
        Set(ByVal value As String)
            sSerialNumber = value
        End Set
    End Property

    Public Property Quantidade() As Integer
        Get
            Return iQuantidade
        End Get
        Set(ByVal value As Integer)
            iQuantidade = value
        End Set
    End Property

    Public Property CodigoPrestador() As Long
        Get
            Return lCodigoPrestador
        End Get
        Set(ByVal value As Long)
            lCodigoPrestador = value
        End Set
    End Property

    Public Property CodigoResponsavelFechamento() As Integer
        Get
            Return iCodigoResponsavelFechamento
        End Get
        Set(ByVal value As Integer)
            iCodigoResponsavelFechamento = value
        End Set
    End Property

    Public Property PoFornecedor() As String
        Get
            Return sPOFornecedor
        End Get
        Set(ByVal value As String)
            sPOFornecedor = value
        End Set
    End Property

    Public Property Delta() As String
        Get
            Return sDelta
        End Get
        Set(ByVal value As String)
            sDelta = value
        End Set
    End Property


    Public Property Codigo() As Integer
        Get
            Return iCodigo
        End Get
        Set(ByVal value As Integer)
            iCodigo = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

    Public Sub Insert()

        'Variaveis Locais
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Modelo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoPedidoItem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPedidoItemEntrega : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_qualidade_ncr", oSqlParameter)

            iCodigo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertDefeito(ByVal sDefeito As String)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ncr"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "defeito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDefeito : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_qualidade_ncr_defeito", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateDefeito(ByVal iCodigo As Integer, _
                             ByVal iCodigoDefeito As Integer, _
                             ByVal sDefeito As String)

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Modelo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ncr"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "defeito"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDefeito : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoDefeito : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_qualidade_ncr_defeito", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Update()

        'Variaveis Locais
        Dim oSqlParameter(16) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "nc_sob_no"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNcSobNo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "status"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iStatus = -1, DBNull.Value, iStatus) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fluxo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sFluxo : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoCliente = -1, DBNull.Value, lCodigoCliente) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_responsavel_abertura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoResponsavelAbertura = -1, DBNull.Value, iCodigoResponsavelAbertura) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_abertura"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sDataAbertura : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_rfp"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sRFP : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_po"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sNumeroPO : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "part_number"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sPartNumber : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "serial_number"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sSerialNumber : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iQuantidade : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_prestador"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = IIf(lCodigoPrestador = -1, DBNull.Value, lCodigoPrestador) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_responsavel_fechamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoResponsavelFechamento = -1, DBNull.Value, iCodigoResponsavelFechamento) : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "po_fornecedor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sPOFornecedor : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "delta"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDelta : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_qualidade_ncr", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGrid(ByVal oGrid As GridEX, _
                        ByVal lNumeroPedido As Long, _
                        ByVal sItem As String, _
                        ByVal sDataPedidoInicio As String, _
                        ByVal sDataPedidoTermino As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(4) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código País
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lNumeroPedido : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sItem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pedido_inicio"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Date
            oSqlParameter(i).Value = sDataPedidoInicio : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data_pedido_termino"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Value = sDataPedidoTermino : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_qualidade_ncr", oSqlParameter)

            Dim oParentColumn(2) As DataColumn
            Dim oChildColumn(2) As DataColumn

            oParentColumn(0) = oDataSet.Tables(0).Columns("codigo_pedido")
            oParentColumn(1) = oDataSet.Tables(0).Columns("codigo_pedido_item")
            oParentColumn(2) = oDataSet.Tables(0).Columns("codigo_pedido_item_entrega")
            oChildColumn(0) = oDataSet.Tables(1).Columns("codigo_pedido")
            oChildColumn(1) = oDataSet.Tables(1).Columns("codigo_pedido_item")
            oChildColumn(2) = oDataSet.Tables(1).Columns("codigo_pedido_item_entrega")

            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oParentColumn, oChildColumn)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(2).TableName, oDataSet.Tables(1).Columns("codigo_ncr"), oDataSet.Tables(2).Columns("codigo_ncr"))

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Carrega Grid
            oGrid.DataSource = oDataSet.DefaultViewManager
            oGrid.DataMember = oDataSet.Tables(0).TableName : oGrid.MoveFirst()
            oGrid.RootTable.ChildTables(0).DataMember = oDataSet.Tables(1).TableName
            oGrid.RootTable.ChildTables(0).ChildTables(0).DataMember = oDataSet.Tables(2).TableName

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridDefeito(ByVal oGrid As GridEX, _
                               ByVal iCodigoNcr As Integer)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_ncr"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoNcr : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_qualidade_ncr_defeito", oSqlParameter)

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

    Public Sub DeleteDefeito(ByVal iCodigoNcr As Integer)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Pedido
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Código Pedido Item
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_ncr"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = iCodigoNcr : i += 1

                'Seta Parametros - Código Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_qualidade_ncr_defeito", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub Editar(ByVal iCodigo As Integer, _
                      ByVal txtNcSobNo As MaskedEditBox, _
                      ByVal cboStatus As UIComboBox, _
                      ByVal txtFluxo As MaskedEditBox, _
                      ByVal cboCliente As UIComboBox, _
                      ByVal cboResponsavelAbertura As UIComboBox, _
                      ByVal dtpDataAbertura As CalendarCombo, _
                      ByVal txtRFP As MaskedEditBox, _
                      ByVal txtPO As MaskedEditBox, _
                      ByVal txtPartNumber As MaskedEditBox, _
                      ByVal txtSerialNumber As MaskedEditBox, _
                      ByVal txtQuantidade As NumericEditBox, _
                      ByVal cboPrestador As UIComboBox, _
                      ByVal cboResponsavelFechamento As UIComboBox, _
                      ByVal txtPOFornecedor As MaskedEditBox, _
                      ByVal txtDelta As MaskedEditBox, _
                      ByVal txtPedidoCompra As MaskedEditBox, _
                      ByVal txtFornecedorPedidoCompra As MaskedEditBox, _
                      ByVal txtProduto As MaskedEditBox, _
                      ByVal txtDescricao As MaskedEditBox, _
                      ByVal txtQuantidadeCompra As NumericEditBox, _
                      ByVal txtUnidadeMedida As MaskedEditBox, _
                      ByVal dtpDataPrevisaoEntrega As CalendarCombo)

        'Variaveis Locais
        Dim oSqlDataReader As SqlDataReader
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = iCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_qualidade_ncr_dados", oSqlParameter)

            'Verifica se encontrou algum Registro
            If oSqlDataReader.HasRows Then

                'Seta Controles
                While oSqlDataReader.Read

                    If IsDBNull(oSqlDataReader.Item("status")) Then
                        cboStatus.SelectedIndex = -1
                    Else
                        cboStatus.SelectedValue = oSqlDataReader.Item("status")
                    End If

                    If IsDBNull(oSqlDataReader.Item("codigo_cliente")) Then
                        cboCliente.SelectedIndex = -1
                    Else
                        cboCliente.SelectedValue = oSqlDataReader.Item("codigo_cliente")
                    End If

                    If IsDBNull(oSqlDataReader.Item("codigo_responsavel_abertura")) Then
                        cboResponsavelAbertura.SelectedIndex = -1
                    Else
                        cboResponsavelAbertura.SelectedValue = oSqlDataReader.Item("codigo_responsavel_abertura")
                    End If

                    If IsDBNull(oSqlDataReader.Item("codigo_responsavel_fechamento")) Then
                        cboResponsavelFechamento.SelectedIndex = -1
                    Else
                        cboResponsavelFechamento.SelectedValue = oSqlDataReader.Item("codigo_responsavel_fechamento")
                    End If

                    If IsDBNull(oSqlDataReader.Item("codigo_prestador")) Then
                        cboPrestador.SelectedIndex = -1
                    Else
                        cboPrestador.SelectedValue = oSqlDataReader.Item("codigo_prestador")
                    End If

                    txtNcSobNo.Text = oSqlDataReader.Item("nc_sob_no")
                    txtFluxo.Text = oSqlDataReader.Item("fluxo")
                    dtpDataAbertura.Value = oSqlDataReader.Item("data_abertura")
                    txtRFP.Text = oSqlDataReader.Item("numero_rfp")
                    txtPO.Text = oSqlDataReader.Item("numero_po")
                    txtPartNumber.Text = oSqlDataReader.Item("part_number")
                    txtSerialNumber.Text = oSqlDataReader.Item("serial_number")
                    txtQuantidade.Value = oSqlDataReader.Item("quantidade")
                    txtPOFornecedor.Text = oSqlDataReader.Item("fornecedor")
                    txtDelta.Text = oSqlDataReader.Item("delta")
                    txtPedidoCompra.Text = oSqlDataReader.Item("pedido_compra")
                    txtFornecedorPedidoCompra.Text = oSqlDataReader.Item("fornecedor")
                    txtProduto.Text = oSqlDataReader.Item("produto")
                    txtDescricao.Text = oSqlDataReader.Item("descricao")
                    txtQuantidadeCompra.Value = oSqlDataReader.Item("quantidade_compra")
                    txtUnidadeMedida.Text = oSqlDataReader.Item("unidade_medida")
                    dtpDataPrevisaoEntrega.Value = oSqlDataReader.Item("data_previsao_entrega")

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

    Public Function ValidaNCR(ByVal lCodigoPedido As Long, _
                              ByVal iCodigoPedidoItem As Integer, _
                              ByVal iCodigoPedidoItemEntrega As Integer) As Boolean

        'Variaveis Locais
        Dim oSqlParameter(3) As SqlParameter
        Dim iReturn As Integer
        Dim i As Integer = 0

        Try

            'Seta Retorno da Função
            ValidaNCR = False

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoPedido : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPedidoItem : i += 1

            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_pedido_item_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoPedidoItemEntrega : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            iReturn = CType(ExecuteScalar(goDatabase.sConnection, CommandType.StoredProcedure, "sp_validate_qualidade_ncr", oSqlParameter), String)

            'Seta Retorno da Função
            ValidaNCR = IIf(iReturn > 0, False, True)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Function

#End Region

End Class
