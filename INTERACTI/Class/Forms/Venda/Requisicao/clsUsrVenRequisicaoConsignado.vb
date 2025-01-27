Imports System.Data
Imports System.Data.SqlClient
Imports INTERACTI.SQLHelper
Imports Janus.Windows.GridEX
Imports Janus.Windows.EditControls
Imports Janus.Windows.GridEX.EditControls
Imports Janus.Windows.CalendarCombo

Public Class clsUsrVenRequisicaoConsignado

#Region "::: VARIAVEIS :::"

    'Variaveis da Classe
    Private sNumeroRequisicao As String
    Private sData As String
    Private iCodigoCliente As Integer
    Private sDescritivo As String
    Private iCodigoMoeda As Integer
    Private dFatorCambial As Double
    Private iCodigoCondicaoPagamento As Integer
    Private iCodigoFormaPagamento As Integer
    Private iCodigoModalidadeFrete As Integer
    Private iCodigoTransportadora As Integer
    Private iCodigoTomador As Integer
    Private iCodigoEnderecoEntrega As Integer
    Private sTermoGarantia As String
    Private sCondicaoFornecimento As String
    Private sObservacao As String
    Private dValorFrete As Double
    Private dDescontoGeral As Double
    Private dAcrescimoGeral As Double
    Private dValorFinal As Double
    Private lCodigoRequisicao As Long

#End Region

#Region "::: PROPERTIE :::"

    Public Property NumeroRequisicao() As String
        Get
            Return sNumeroRequisicao
        End Get
        Set(ByVal value As String)
            sNumeroRequisicao = value
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

    Public Property CodigoCliente() As Integer
        Get
            Return iCodigoCliente
        End Get
        Set(ByVal value As Integer)
            iCodigoCliente = value
        End Set
    End Property

    Public Property Descritivo() As String
        Get
            Return sDescritivo
        End Get
        Set(ByVal value As String)
            sDescritivo = value
        End Set
    End Property

    Public Property CodigoMoeda() As Integer
        Get
            Return iCodigoMoeda
        End Get
        Set(ByVal value As Integer)
            iCodigoMoeda = value
        End Set
    End Property

    Public Property FatorCambial() As Double
        Get
            Return dFatorCambial
        End Get
        Set(ByVal value As Double)
            dFatorCambial = value
        End Set
    End Property

    Public Property CodigoCondicaoPagamento() As Integer
        Get
            Return iCodigoCondicaoPagamento
        End Get
        Set(ByVal value As Integer)
            iCodigoCondicaoPagamento = value
        End Set
    End Property

    Public Property CodigoFormaPagamento() As Integer
        Get
            Return iCodigoFormaPagamento
        End Get
        Set(ByVal value As Integer)
            iCodigoFormaPagamento = value
        End Set
    End Property

    Public Property CodigoModalidadeFrete() As Integer
        Get
            Return iCodigoModalidadeFrete
        End Get
        Set(ByVal value As Integer)
            iCodigoModalidadeFrete = value
        End Set
    End Property

    Public Property CodigoTomador() As Integer
        Get
            Return iCodigoTomador
        End Get
        Set(ByVal value As Integer)
            iCodigoTomador = value
        End Set
    End Property

    Public Property CodigoTransportadora() As Integer
        Get
            Return iCodigoTransportadora
        End Get
        Set(ByVal value As Integer)
            iCodigoTransportadora = value
        End Set
    End Property

    Public Property CodigoEnderecoEntrega() As Integer
        Get
            Return iCodigoEnderecoEntrega
        End Get
        Set(ByVal value As Integer)
            iCodigoEnderecoEntrega = value
        End Set
    End Property

    Public Property CondicaoFornecimento() As String
        Get
            Return sCondicaoFornecimento
        End Get
        Set(ByVal value As String)
            sCondicaoFornecimento = value
        End Set
    End Property

    Public Property TermoGarantia() As String
        Get
            Return sTermoGarantia
        End Get
        Set(ByVal value As String)
            sTermoGarantia = value
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

    Public Property ValorFrete() As Double
        Get
            Return dValorFrete
        End Get
        Set(ByVal value As Double)
            dValorFrete = value
        End Set
    End Property

    Public Property DescontoGeral() As Double
        Get
            Return dDescontoGeral
        End Get
        Set(ByVal value As Double)
            dDescontoGeral = value
        End Set
    End Property

    Public Property AcrescimoGeral() As Double
        Get
            Return dAcrescimoGeral
        End Get
        Set(ByVal value As Double)
            dAcrescimoGeral = value
        End Set
    End Property

    Public Property ValorFinal() As Double
        Get
            Return dValorFinal
        End Get
        Set(ByVal value As Double)
            dValorFinal = value
        End Set
    End Property

    Public Property CodigoRequisicao() As Long
        Get
            Return lCodigoRequisicao
        End Get
        Set(ByVal value As Long)
            lCodigoRequisicao = value
        End Set
    End Property

#End Region

#Region "::: FUNCTION / SUB :::"

#Region "::: REQUISIÇÃO :::"

    Public Sub LoadGridRequisicao(ByVal oGrid As GridEX, _
                                  ByVal sNumeroRequisicao As String, _
                                  ByVal sDataInicio As String, _
                                  ByVal sDataTermino As String, _
                                  ByVal iCodigoCliente As Integer, _
                                  ByVal sDescritivo As String, _
                                  ByVal sProduto As String)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(7) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Nº Requisição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_requisicao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20
            oSqlParameter(i).Value = sNumeroRequisicao : i += 1

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

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente : i += 1

            'Seta Parametros - Descritivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descritivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 250
            oSqlParameter(i).Value = sDescritivo : i += 1

            'Seta Parametros - Produto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "produto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 120
            oSqlParameter(i).Value = sProduto : i += 1

            'Seta Parametros - Codigo Usuário
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
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_requisicao_consignado", oSqlParameter)

            'Configura DataMember
            Call ConfigurarDataMemberGrid(oGrid)

            'Adiciona Relacionamento
            oDataSet.Relations.Add(oDataSet.Tables(1).TableName, oDataSet.Tables(0).Columns("codigo"), oDataSet.Tables(1).Columns("codigo"))

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

    Public Sub EditarRequisicao(ByVal lCodigo As Long, _
                                ByVal txtNumeroRequisicao As MaskedEditBox, _
                                ByVal dtpData As CalendarCombo, _
                                ByVal cboCliente As UIComboBox, _
                                ByVal txtDescritivo As MaskedEditBox, _
                                ByVal cboCondicaoPagamento As UIComboBox, _
                                ByVal cboFormaPagamento As UIComboBox, _
                                ByVal cboModalidadeFrete As UIComboBox, _
                                ByVal cboMoeda As UIComboBox, _
                                ByVal txtFatorCambial As NumericEditBox, _
                                ByVal cboTomador As UIComboBox, _
                                ByVal cboTransportadora As UIComboBox, _
                                ByVal cboEnderecoEntrega As UIComboBox, _
                                ByVal txtTermoGarantia As EditBox, _
                                ByVal txtCondicaoFornecimento As EditBox, _
                                ByVal txtObservacao As EditBox)

        'Variaveis Locais
        Dim oSqlParameter(1) As SqlParameter
        Dim oSqlDataReader As SqlDataReader
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigo : i += 1

            'Seta Parametros - Código Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oSqlDataReader = ExecuteReader(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_requisicao_consignado_dados", oSqlParameter)

            While oSqlDataReader.Read

                txtNumeroRequisicao.Text = oSqlDataReader.Item("numero_requisicao")
                dtpData.Value = oSqlDataReader.Item("data")
                cboCliente.SelectedValue = oSqlDataReader.Item("codigo_cliente")
                txtDescritivo.Text = oSqlDataReader.Item("descritivo")
                cboCondicaoPagamento.SelectedValue = oSqlDataReader.Item("codigo_condicao_pagamento")
                cboFormaPagamento.SelectedValue = oSqlDataReader.Item("codigo_forma_pagamento")
                cboModalidadeFrete.SelectedValue = oSqlDataReader.Item("codigo_modalidade_frete")
                cboMoeda.SelectedValue = oSqlDataReader.Item("codigo_moeda")
                txtFatorCambial.Value = oSqlDataReader.Item("fator_cambial")
                cboTomador.SelectedValue = oSqlDataReader.Item("codigo_tomador")
                cboTransportadora.SelectedValue = oSqlDataReader.Item("codigo_transportadora")
                cboEnderecoEntrega.SelectedValue = oSqlDataReader.Item("codigo_endereco_entrega")
                txtTermoGarantia.Text = oSqlDataReader.Item("termo_garantia")
                txtCondicaoFornecimento.Text = oSqlDataReader.Item("condicao_fornecimento")
                txtObservacao.Text = oSqlDataReader.Item("observacao")

            End While

            'Feca o SqlDataReader
            If oSqlDataReader.IsClosed = False Then oSqlDataReader.Close() : oSqlDataReader = Nothing

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertRequisicao()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_requisicao_consignado", oSqlParameter)

            'Seta Váriaveis
            lCodigoRequisicao = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateRequisicao()

        'Variaveis Locais
        Dim oSqlParameter(21) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Nº Requisição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "numero_requisicao"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 20 : i += 1

            'Seta Parametros - Data
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "data"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.DateTime
            oSqlParameter(i).Value = sData : i += 1

            'Seta Parametros - Código Cliente
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_cliente"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoCliente : i += 1

            'Seta Parametros - Descritivo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "descritivo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 250
            oSqlParameter(i).Value = sDescritivo : i += 1

            'Seta Parametros - Código Condição de Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_condicao_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoCondicaoPagamento = -1, DBNull.Value, iCodigoCondicaoPagamento) : i += 1

            'Seta Parametros - Código Forma de Pagamento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_forma_pagamento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoFormaPagamento = -1, DBNull.Value, iCodigoFormaPagamento) : i += 1

            'Seta Parametros - Código Modalidade de Frete
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_modalidade_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoModalidadeFrete = -1, DBNull.Value, iCodigoModalidadeFrete) : i += 1

            'Seta Parametros - Código Moeda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_moeda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = iCodigoMoeda : i += 1

            'Seta Parametros - Fator Cambial
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "fator_cambial"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dFatorCambial : i += 1

            'Seta Parametros - Código Tomador
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_tomador"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoTomador = -1, DBNull.Value, iCodigoTomador) : i += 1

            'Seta Parametros - Código Transportadora
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_transportadora"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = IIf(iCodigoTransportadora = -1, DBNull.Value, iCodigoTransportadora) : i += 1

            'Seta Parametros - Código Cliente - Endereço
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_endereco_entrega"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = IIf(iCodigoEnderecoEntrega = -1, DBNull.Value, iCodigoEnderecoEntrega) : i += 1

            'Seta Parametros - Termo de Garantia
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "termo_garantia"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = IIf(sTermoGarantia = "", DBNull.Value, sTermoGarantia) : i += 1

            'Seta Parametros - Condição de Fornecimento
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "condicao_fornecimento"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = IIf(sCondicaoFornecimento = "", DBNull.Value, sCondicaoFornecimento) : i += 1

            'Seta Parametros - Observação
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "observacao"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.VarChar
            oSqlParameter(i).Size = 5000
            oSqlParameter(i).Value = IIf(sObservacao = "", DBNull.Value, sObservacao) : i += 1

            'Seta Parametros - Codigo Usuário
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_usuario"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

            'Seta Parametros - Valor Frete
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_frete"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFrete : i += 1

            'Seta Parametros - Desconto Geral
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_geral"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoGeral : i += 1

            'Seta Parametros - Acrescimo Geral
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "acrescimo_geral"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAcrescimoGeral : i += 1

            'Seta Parametros - Valor Final
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_final"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorFinal : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Código
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRequisicao

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_requisicao_consignado", oSqlParameter)

            'Seta Váriavel
            sNumeroRequisicao = oSqlParameter(0).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub DeleteRequisicao()

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = oRow.Cells("codigo").Value : i += 1

                'Seta Parametros - Codigo Usuário
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_usuario"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = goUsuario.iUsuario : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_requisicao_consignado", oSqlParameter)

                'Exclui Linha
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

#End Region

#Region "::: PRODUTO :::"

    Public Sub DeleteProduto(ByVal lCodigoRequisicao As Long)

        'Variaveis Locais
        Dim oSqlParameter(2) As SqlParameter
        Dim i As Integer = 0

        Try

            For Each oRow As GridEXRow In gSelecaoRow

                'Seta Váriavel
                i = 0

                'Seta Parametros - Código Requisição
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_requisicao"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.BigInt
                oSqlParameter(i).Value = lCodigoRequisicao : i += 1

                'Seta Parametros - Codigo Empresa
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo_empresa"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
                oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

                'Seta Parametros - Código
                oSqlParameter(i) = New SqlParameter
                oSqlParameter(i).ParameterName = "codigo"
                oSqlParameter(i).Direction = ParameterDirection.Input
                oSqlParameter(i).SqlDbType = SqlDbType.Int
                oSqlParameter(i).Value = oRow.Cells("codigo").Value

                'Executa Query
                ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_delete_venda_requisicao_consignado_produto", oSqlParameter)

                'Exclui Registro
                oRow.Delete()

            Next

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub InsertProduto(ByVal lCodigoRequisicao As Long, _
                             ByVal lCodigoItem As Long, _
                             ByVal dQuantidade As Double, _
                             ByVal iCodigoUnidadeMedida As Integer, _
                             ByVal dPrecoTabela As Double, _
                             ByVal dDescontoPercentual As Double, _
                             ByVal dDescontoValor As Double, _
                             ByVal dValorUnitarioDesconto As Double, _
                             ByVal bICMSEmbutido As Boolean, _
                             ByVal dAliquotaICMS As Double, _
                             ByVal dValorICMS As Double, _
                             ByVal bIPIEmbutido As Boolean, _
                             ByVal dAliquotaIPI As Double, _
                             ByVal dValorIPI As Double, _
                             ByVal bPISCOFINSEmbutido As Boolean, _
                             ByVal dAliquotaPISCOFINS As Double, _
                             ByVal dValorPISCOFINS As Double, _
                             ByVal dPrecoVenda As Double, _
                             ByRef iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(19) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Requisição Consignado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_requisicao_consignado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRequisicao : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Código Unidade Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedida : i += 1

            'Seta Parametros - Preço Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoTabela : i += 1

            'Seta Parametros - Desconto Percentual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_percentual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoPercentual : i += 1

            'Seta Parametros - Desconto Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoValor : i += 1

            'Seta Parametros - Valor Unitário Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitarioDesconto : i += 1

            'Seta Parametros - ICMS Embutido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "icms_embutido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bICMSEmbutido : i += 1

            'Seta Parametros - Alíquota ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMS : i += 1

            'Seta Parametros - Valor ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorICMS : i += 1

            'Seta Parametros - IPI Embutido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ipi_embutido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bICMSEmbutido : i += 1

            'Seta Parametros - Alíquota IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMS : i += 1

            'Seta Parametros - Valor IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorICMS : i += 1

            'Seta Parametros - PIS / COFINS Embutido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pis_cofins_embutido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bICMSEmbutido : i += 1

            'Seta Parametros - Alíquota PIS / COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_pis_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMS : i += 1

            'Seta Parametros - Valor PIS / COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_pis_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorICMS : i += 1

            'Seta Parametros - Preço de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoVenda : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Output
            oSqlParameter(i).SqlDbType = SqlDbType.Int

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_insert_venda_requisicao_consignado_produto", oSqlParameter)

            'Seta Váriavel
            iCodigo = oSqlParameter(i).Value

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub UpdateProduto(ByVal lCodigoRequisicao As Long, _
                             ByVal lCodigoItem As Long, _
                             ByVal dQuantidade As Double, _
                             ByVal iCodigoUnidadeMedida As Integer, _
                             ByVal dPrecoTabela As Double, _
                             ByVal dDescontoPercentual As Double, _
                             ByVal dDescontoValor As Double, _
                             ByVal dValorUnitarioDesconto As Double, _
                             ByVal bICMSEmbutido As Boolean, _
                             ByVal dAliquotaICMS As Double, _
                             ByVal dValorICMS As Double, _
                             ByVal bIPIEmbutido As Boolean, _
                             ByVal dAliquotaIPI As Double, _
                             ByVal dValorIPI As Double, _
                             ByVal bPISCOFINSEmbutido As Boolean, _
                             ByVal dAliquotaPISCOFINS As Double, _
                             ByVal dValorPISCOFINS As Double, _
                             ByVal dPrecoVenda As Double, _
                             ByVal iCodigo As Integer)

        'Variaveis Locais
        Dim oSqlParameter(19) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Requisição Consignado
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_requisicao_consignado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRequisicao : i += 1

            'Seta Parametros - Código Item
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_item"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoItem : i += 1

            'Seta Parametros - Quantidade
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "quantidade"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dQuantidade : i += 1

            'Seta Parametros - Código Unidade Medida
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_unidade_medida"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigoUnidadeMedida : i += 1

            'Seta Parametros - Preço Tabela
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_tabela"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoTabela : i += 1

            'Seta Parametros - Desconto Percentual
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_percentual"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoPercentual : i += 1

            'Seta Parametros - Desconto Valor
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "desconto_valor"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dDescontoValor : i += 1

            'Seta Parametros - Valor Unitário Desconto
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_unitario_desconto"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorUnitarioDesconto : i += 1

            'Seta Parametros - ICMS Embutido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "icms_embutido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bICMSEmbutido : i += 1

            'Seta Parametros - Alíquota ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMS : i += 1

            'Seta Parametros - Valor ICMS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_icms"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorICMS : i += 1

            'Seta Parametros - IPI Embutido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "ipi_embutido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bICMSEmbutido : i += 1

            'Seta Parametros - Alíquota IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMS : i += 1

            'Seta Parametros - Valor IPI
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_ipi"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorICMS : i += 1

            'Seta Parametros - PIS / COFINS Embutido
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "pis_cofins_embutido"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Bit
            oSqlParameter(i).Value = bICMSEmbutido : i += 1

            'Seta Parametros - Alíquota PIS / COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "aliquota_pis_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dAliquotaICMS : i += 1

            'Seta Parametros - Valor PIS / COFINS
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "valor_pis_cofins"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dValorICMS : i += 1

            'Seta Parametros - Preço de Venda
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "preco_venda"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Float
            oSqlParameter(i).Value = dPrecoVenda : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa : i += 1

            'Seta Parametros - Codigo
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.Int
            oSqlParameter(i).Value = iCodigo

            'Executa Query
            ExecuteNonQuery(goDatabase.sConnection, CommandType.StoredProcedure, "sp_update_venda_requisicao_consignado_produto", oSqlParameter)

        Catch SqlEx As SqlException
            Throw SqlEx
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Sub LoadGridProduto(ByVal oGrid As GridEX, _
                               ByVal lCodigoRequisicao As Long)

        'Variaveis Locais
        Dim oDataSet As DataSet
        Dim oSqlParameter(1) As SqlParameter
        Dim i As Integer = 0

        Try

            'Seta Parametros - Código Requisição
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_requisicao_consignado"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.BigInt
            oSqlParameter(i).Value = lCodigoRequisicao : i += 1

            'Seta Parametros - Codigo Empresa
            oSqlParameter(i) = New SqlParameter
            oSqlParameter(i).ParameterName = "codigo_empresa"
            oSqlParameter(i).Direction = ParameterDirection.Input
            oSqlParameter(i).SqlDbType = SqlDbType.SmallInt
            oSqlParameter(i).Value = goUsuario.iEmpresa

            'Executa Query
            oDataSet = ExecuteDataset(goDatabase.sConnection, CommandType.StoredProcedure, "sp_select_venda_requisicao_consignado_produto", oSqlParameter)

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

#End Region

End Class
